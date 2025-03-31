using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.Database;
using System.Data.SqlClient;
using C969.Forms;

namespace C969.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCustomerDGV();
            LoadAppointmentDGV();
        }

        private void MainAddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomerFormInstance = new AddCustomer();
            newAddCustomerFormInstance.FormClosed += newCustomerFormInstance_FormClosed;
            newAddCustomerFormInstance.ShowDialog();
        }

        private void MainAddAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointment newAddAppointmentFormInstance = new AddAppointment();
            newAddAppointmentFormInstance.FormClosed += newAppointmentFormInstance_FormClosed;
            newAddAppointmentFormInstance.ShowDialog();
        }

        private void MainDeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (MainCustomerDGV.SelectedRows.Count > 0)
            {
                // Retrieve the selected customer's Id
                int customerId = Convert.ToInt32(MainCustomerDGV.SelectedRows[0].Cells["customerId"].Value);

                DialogResult deletionResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Customer Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deletionResult == DialogResult.Yes)
                {
                    string deleteAppointmentQuery = "DELETE FROM appointment WHERE customerId = @customerId";
                    string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId";

                    DBConnection.startConnection();
                    using (MySqlCommand cmd = new MySqlCommand(deleteAppointmentQuery, DBConnection.conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(deleteCustomerQuery, DBConnection.conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }
                    DBConnection.closeConnection();

                    MessageBox.Show("Customer was successfully deleted.");

                    LoadCustomerDGV();
                }
            }
        }

        private void MainDeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            int appointmentId = RetrieveAppointmentIdFromDGV();

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteAppointment(appointmentId);
                LoadAppointmentDGV();

                MessageBox.Show("Appointed deleted successfully.");
            }
        }

        private void MainEditCustomerButton_Click(object sender, EventArgs e)
        {
            if (RetrieveCustomerIdFromDGV() != -1)
            {
                int customerId = RetrieveCustomerIdFromDGV();

                EditCustomer newEditCustomerFormInstance = new EditCustomer(customerId);
                newEditCustomerFormInstance.FormClosed += newCustomerFormInstance_FormClosed;
                newEditCustomerFormInstance.ShowDialog();
            }
        }

        private void MainEditAppointmentButton_Click(object sender, EventArgs e)
        {
            if (RetrieveAppointmentIdFromDGV() != -1)
            {
                int appointmentId = RetrieveAppointmentIdFromDGV();

                EditAppointment newEditAppointmentFormInstance = new EditAppointment(appointmentId);
                newEditAppointmentFormInstance.FormClosed += newAppointmentFormInstance_FormClosed;
                newEditAppointmentFormInstance.ShowDialog();
            }
        }

        private int RetrieveCustomerIdFromDGV()
        {
            if (MainCustomerDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedCustomerRow = MainCustomerDGV.SelectedRows[0];
                return Convert.ToInt32(selectedCustomerRow.Cells["customerId"].Value);
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
                return -1;
            }
        }

        private int RetrieveAppointmentIdFromDGV()
        {
            if (MainAppointmentDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedAppointmentRow = MainAppointmentDGV.SelectedRows[0];
                return Convert.ToInt32(selectedAppointmentRow.Cells["appointmentId"].Value);
            }
            else
            {
                MessageBox.Show("Please select appointment to delete.");
                return -1;
            }
        }

        private void DeleteAppointment(int appointmentId)
        {
            string deleteAppointmentQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(deleteAppointmentQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }
            DBConnection.closeConnection();
        }

        private void LoadCustomerDGV()
        {
            string customerDGVQuery = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM customer";

            DBConnection.startConnection();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(customerDGVQuery, DBConnection.conn);
            DataTable customerDT = new DataTable();
            sqlDataAdapter.Fill(customerDT);
            MainCustomerDGV.DataSource = customerDT;

            DBConnection.closeConnection();

            FormatCustomerDGV();
        }

        private void LoadAppointmentDGV()
        {
            string appointmentDGVQuery = "SELECT appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy,lastUpdate, lastUpdateBy FROM appointment";

            DBConnection.startConnection();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(appointmentDGVQuery, DBConnection.conn);
            DataTable appointmentDT = new DataTable();
            sqlDataAdapter.Fill(appointmentDT);
            MainAppointmentDGV.DataSource = appointmentDT;

            DBConnection.closeConnection();

            FormatAppointmentDGV();
        }

        private void FormatCustomerDGV()
        {
            MainCustomerDGV.Columns["customerId"].HeaderText = "Customer ID";
            MainCustomerDGV.Columns["customerName"].HeaderText = "Customer Name";
            MainCustomerDGV.Columns["addressId"].HeaderText = "Address ID";
            MainCustomerDGV.Columns["active"].HeaderText = "Active";
            MainCustomerDGV.Columns["createDate"].HeaderText = "Create Date";
            MainCustomerDGV.Columns["createdBy"].HeaderText = "Created By";
            MainCustomerDGV.Columns["lastUpdate"].HeaderText = "Last Update";
            MainCustomerDGV.Columns["lastUpdateBy"].HeaderText = "Last Update By";
        }

        private void FormatAppointmentDGV()
        {
            MainAppointmentDGV.Columns["appointmentId"].HeaderText = "Appointment ID";
            MainAppointmentDGV.Columns["customerId"].HeaderText = "Customer ID";
            MainAppointmentDGV.Columns["userId"].HeaderText = "User ID";
            MainAppointmentDGV.Columns["title"].HeaderText = "Title";
            MainAppointmentDGV.Columns["description"].HeaderText = "Description";
            MainAppointmentDGV.Columns["location"].HeaderText = "Location";
            MainAppointmentDGV.Columns["contact"].HeaderText = "Contact";
            MainAppointmentDGV.Columns["type"].HeaderText = "Type";
            MainAppointmentDGV.Columns["url"].HeaderText = "URL";
            MainAppointmentDGV.Columns["start"].HeaderText = "Start";
            MainAppointmentDGV.Columns["end"].HeaderText = "End";
            MainAppointmentDGV.Columns["createDate"].HeaderText = "Create Date";
            MainAppointmentDGV.Columns["createdBy"].HeaderText = "Created By";
            MainAppointmentDGV.Columns["lastUpdate"].HeaderText = "Last Update";
            MainAppointmentDGV.Columns["lastUpdateBy"].HeaderText = "Last Update By";
        }

        private void newCustomerFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomerDGV();
        }

        private void newAppointmentFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAppointmentDGV();
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainCustomerDGV.ClearSelection();
        }

        private void myBindingComplete2(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainAppointmentDGV.ClearSelection();
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainAppointmentMontCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            LoadAppointmentBySelectedDate(selectedDate);
        }

        private void LoadAppointmentBySelectedDate(DateTime selectedDate)
        {
            string dateQuery = "SELECT appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy,lastUpdate, lastUpdateBy FROM appointment WHERE CAST(start AS DATE) = @selectedDate";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(dateQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable appointmendDataTable = new DataTable();
                    adapter.Fill(appointmendDataTable);
                    MainAppointmentDGV.DataSource = appointmendDataTable;
                }
            }
            DBConnection.closeConnection();
        }

        private void MainMonthCalendarResetButton_Click(object sender, EventArgs e)
        {
            LoadAppointmentDGV();
        }

        private void MainAppoinmentTypeByMonthButton_Click(object sender, EventArgs e)
        {
            AppointmentTypesByMonth newAppointmentTypesByMonthFormInstance = new AppointmentTypesByMonth();
            newAppointmentTypesByMonthFormInstance.Show();
        }

        private void MainScheduleByEachUserButton_Click(object sender, EventArgs e)
        {
            ScheduleByUser newScheduleByUserInstance = new ScheduleByUser();
            newScheduleByUserInstance.Show();
        }

        private void NumberOfUserReportButton_Click(object sender, EventArgs e)
        {
            NumberOfUsers newNumberOfUsersInstance = new NumberOfUsers();
            newNumberOfUsersInstance.Show();
        }
    }
}
