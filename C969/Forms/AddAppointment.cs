using C969.Database;
using C969.Global;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969.Forms
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            LoadCustomerNames();
        }

        private void AddAppointmentSubmitButton_Click(object sender, EventArgs e)
        {
            ValidateInputs(GlobalVariables.LoggedInUserId);
        }

        private void AddTheAppointment(int userId)
        {
            try
            {
                string typeInput = AddAppointmentTypeTextBox.Text.Trim();
                int customerIdInput = RetrieveCustomerId();
                DateTime startInput = AddAppointmentStartDateTimePicker.Value;
                DateTime endInput = AddAppointmentEndDateTimePicker.Value;

                string titleInput = "N/A";
                string descriptionInput = "N/A";
                string locationInput = "N/A";
                string contactInput = "N/A";
                string urlInput = "N/A";
                string createDateInput = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string lastUpdateInput = createDateInput;
                string createdByInput = GlobalVariables.loggedInUser;
                string lastUpdateByInput = GlobalVariables.loggedInUser;

                string addAppointmentQuery = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                DBConnection.startConnection();
                using (MySqlCommand cmd = new MySqlCommand(addAppointmentQuery, DBConnection.conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerIdInput);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@title", titleInput);
                    cmd.Parameters.AddWithValue("@description", descriptionInput);
                    cmd.Parameters.AddWithValue("@location", locationInput);
                    cmd.Parameters.AddWithValue("@contact", contactInput);
                    cmd.Parameters.AddWithValue("@type", typeInput);
                    cmd.Parameters.AddWithValue("@url", urlInput);
                    cmd.Parameters.AddWithValue("@start", startInput);
                    cmd.Parameters.AddWithValue("@end", endInput);
                    cmd.Parameters.AddWithValue("@createDate", createDateInput);
                    cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                    cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateByInput);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Appointment added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attempt to add appointment was unsuccessful. Error: {ex.Message}");
            }
            finally
            {
                DBConnection.closeConnection();
            }
            this.Close();
        }

        private void AddAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCustomerNames()
        {
            string customerNameQuery = "SELECT customerId, customerName FROM customer";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(customerNameQuery, DBConnection.conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Dictionary<int, string> customerIdNameData = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        int customerId = Convert.ToInt32(reader["customerId"]);
                        string customerName = reader["customerName"].ToString();

                        customerIdNameData[customerId] = customerNameQuery;
                        AddAppointmentCustomerComboBox.Items.Add(customerName);
                    }
                    AddAppointmentCustomerComboBox.Tag = customerIdNameData;
                }
            }
            DBConnection.closeConnection();
        }

        private int RetrieveCustomerId()
        {
            if (AddAppointmentCustomerComboBox.SelectedItem != null)
            {
                string selectedCustomer = AddAppointmentCustomerComboBox.SelectedItem.ToString();

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

        private void ValidateInputs(int userId)
        {
            // Type
            if (AddAppointmentTypeTextBox.Text == "")
            {
                MessageBox.Show("Please enter a type for the appointment.");
                return;
            }

            // Customer
            if (AddAppointmentCustomerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer for the appointment.");
                return;
            }

            DateTime localStart = AddAppointmentStartDateTimePicker.Value;
            DateTime localEnd = AddAppointmentEndDateTimePicker.Value;

            // Validate Start before End DateTime
            if (localStart >= localEnd)
            {
                MessageBox.Show("Appointment start time must be before the end time.");
                return;
            }

            // Overlapping appointments
            string overlapAppointmentQuery = "SELECT COUNT(*) FROM appointment WHERE userId = @userId AND ((@start >= start AND @start < end) OR (@end > start AND @end <= end) OR (@start <= start AND @end >= end))";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(overlapAppointmentQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId",userId);
                cmd.Parameters.AddWithValue("@start", localStart);
                cmd.Parameters.AddWithValue("@end", localEnd);

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
                AddTheAppointment(GlobalVariables.LoggedInUserId);
            }
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

            TimeSpan businessStart = new TimeSpan(9,0,0);
            TimeSpan businessEnd = new TimeSpan(17,0,0);

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
    }
}
