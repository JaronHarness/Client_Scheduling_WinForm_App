using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.Forms;
using MySql.Data.MySqlClient;
using C969.Database;
using C969.Global;

namespace C969.Forms
{
    public partial class EditAppointment : Form
    {
        private int receivedAppointmentId;

        public EditAppointment(int appointmentId)
        {
            receivedAppointmentId = appointmentId;
            InitializeComponent();
            LoadCustomerNames();
            LoadAppointmentDataToEdit(receivedAppointmentId);
        }

        private void LoadCustomerNames()
        {
            string customerNameQuery = "SELECT customerId, customerName FROM customer";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(customerNameQuery, DBConnection.conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    var customerList = new List<(int customerId, string customerName)>();

                    while (reader.Read())
                    {
                        customerList.Add((
                            Convert.ToInt32(reader["customerId"]),
                            reader["customerName"].ToString()
                        ));
                    }

                    // Used a Lambda to create a Dictionary from the customerList and reduce the ammount of code.
                    var customerIdNameData = customerList.ToDictionary(
                        customer => customer.customerId, // Uses the customerId as the Dict Key
                        customer => customer.customerName // Uses the customerName as the Dict Value
                    );
                    // Lambda to iterate over the list and populate the comboBox. Simply the process with less lines of code.
                    customerList.ForEach(customer => EditAppointmentCustomerComboBox.Items.Add(customer.customerName));

                    EditAppointmentCustomerComboBox.Tag = customerIdNameData;
                }
            }
            DBConnection.closeConnection();
        }
        private void ValidateInputs(int userId, int appointmentId)
        {
            // Type
            if (EditAppointmentTypeTextBox.Text == "")
            {
                MessageBox.Show("Please enter a type for the appointment.");
                return;
            }

            // Customer
            if (EditAppointmentCustomerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer for the appointment.");
                return;
            }

            DateTime localStart = EditAppointmentStartDateTimePicker.Value;
            DateTime localEnd = EditAppointmentEndDateTimePicker.Value;

            // Validate Start before End DateTime
            if (localStart >= localEnd)
            {
                MessageBox.Show("Appointment start time must be before the end time.");
                return;
            }

            // Overlapping appointments
            string overlapAppointmentQuery = "SELECT COUNT(*) FROM appointment WHERE userId = @userId AND appointmentId != appointmentId AND ((@start >= start AND @start < end) OR (@end > start AND @end <= end) OR (@start <= start AND @end >= end))";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(overlapAppointmentQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@start", localStart);
                cmd.Parameters.AddWithValue("@end", localEnd);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                int overlapCheckCount = 0;
                object overlapResult = cmd.ExecuteScalar();

                if (overlapResult != null && overlapResult != DBNull.Value)
                {
                    overlapCheckCount = Convert.ToInt32(overlapResult);

                    if (overlapCheckCount > 0)
                    {
                        MessageBox.Show("This appointment time overlaps with an existing appointment.");
                        return;
                    }
                }
            }
            DBConnection.closeConnection();

            if (BusinessHoursValidation(localStart, localEnd))
            {
                EditTheAppointment();
            }
        }
        private int RetrieveCustomerId()
        {
            if (EditAppointmentCustomerComboBox.SelectedItem != null)
            {
                string selectedCustomer = EditAppointmentCustomerComboBox.SelectedItem.ToString();

                string getCustomerIdQuery = "SELECT customerId FROM customer WHERE customerName = @customerName";

                DBConnection.startConnection();
                using (MySqlCommand cmd = new MySqlCommand(getCustomerIdQuery, DBConnection.conn))
                {
                    cmd.Parameters.AddWithValue("@customerName", selectedCustomer);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new InvalidOperationException("Customer does not exist.");
                    }

                }
            }
            else
            {
                throw new InvalidOperationException("Please select a customer.");
            }

        }

        private void EditTheAppointment()
        {
            try
            {
                string typeInput = EditAppointmentTypeTextBox.Text.Trim();
                int customerIdInput = RetrieveCustomerId();
                DateTime startInput = EditAppointmentStartDateTimePicker.Value;
                DateTime endInput = EditAppointmentEndDateTimePicker.Value;


                string EditAppointmentQuery = "UPDATE appointment SET customerId = @customerId, type = @type, start = @start, end = @end, lastUpdate = NOW(), lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId";

                DBConnection.startConnection();
                using (MySqlCommand cmd = new MySqlCommand(EditAppointmentQuery, DBConnection.conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerIdInput);
                    cmd.Parameters.AddWithValue("@type", typeInput);
                    cmd.Parameters.AddWithValue("@start", startInput);
                    cmd.Parameters.AddWithValue("@end", endInput);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", GlobalVariables.LoggedInUserId);
                    cmd.Parameters.AddWithValue("@appointmentId", receivedAppointmentId);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Appointment edit was successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attempt to edit appointment was unsuccessful. Error: {ex.Message}");
            }
            finally
            {
                DBConnection.closeConnection();
            }
            this.Close();
        }
        private DateTime ConvertDateTimeToEST(DateTime dateTimeInput)
        {
            TimeZoneInfo easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTime(dateTimeInput, TimeZoneInfo.Local, easternStandardTime);
        }

        private bool BusinessHoursValidation(DateTime localStart, DateTime localEnd)
        {
            DateTime startEST = ConvertDateTimeToEST(localStart);
            DateTime endEST = ConvertDateTimeToEST(localEnd);

            TimeSpan businessStart = new TimeSpan(9, 0, 0);
            TimeSpan businessEnd = new TimeSpan(17, 0, 0);

            // Start and End time validation
            if (startEST.TimeOfDay < businessStart || endEST.TimeOfDay < businessEnd)
            {
                MessageBox.Show("Appointment time must be between 9:00 a.m. and 5:00 p.m. EST.");
                return false;
            }

            // Weekdays validation
            if (startEST.DayOfWeek == DayOfWeek.Saturday || startEST.DayOfWeek == DayOfWeek.Sunday || endEST.DayOfWeek == DayOfWeek.Saturday || endEST.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Appointments can only be scheduled Monday - Friday.");
                return false;
            }
            return true;
        }

        private void LoadAppointmentDataToEdit(int appointmentId)
        {
            string loadAppointmentQuery = "SELECT customerId, type, start, end FROM appointment WHERE appointmentId = @appointmentId";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(loadAppointmentQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        EditAppointmentTypeTextBox.Text = reader["type"].ToString();
                        EditAppointmentCustomerComboBox.SelectedItem = GetCustomerNameFromId(Convert.ToInt32(reader["customerId"]));
                        EditAppointmentStartDateTimePicker.Value = Convert.ToDateTime(reader["start"]);
                        EditAppointmentEndDateTimePicker.Value = Convert.ToDateTime(reader["end"]);
                    }
                }
            }
            DBConnection.closeConnection();
        }

        private string GetCustomerNameFromId(int customerId)
        {
            string customerIdQuery = "SELECT customerName FROM customer WHERE customerId = @customerId";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(customerIdQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);

                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? string.Empty; 
            }
        }

        private void EditAppointmentSubmitButton_Click(object sender, EventArgs e)
        {
            ValidateInputs(GlobalVariables.LoggedInUserId, receivedAppointmentId);
        }

        private void EditAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
