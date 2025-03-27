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
using System.Text.RegularExpressions;

namespace C969.Forms
{
    public partial class EditCustomer : Form
    {
        private int receivedCustomerId;

        public EditCustomer(int customerId)
        {
            receivedCustomerId = customerId;
            InitializeComponent();
            LoadCustomerDataToEdit(receivedCustomerId);
        }

        private void LoadCustomerDataToEdit(int customerId)
        {
            string loadCustomerQuery = "SELECT customer.customerName, address.address, address.phone, city.city, country.country FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId WHERE customerId = @customerId";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(loadCustomerQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        EditCustomerNameTextBox.Text = reader["customerName"].ToString();
                        EditCustomerAddressTextBox.Text = reader["address"].ToString();
                        EditCustomerPhoneTextBox.Text = reader["phone"].ToString();
                        EditCustomerCityTextBox.Text = reader["city"].ToString();
                        EditCustomerCountryTextBox.Text = reader["country"].ToString();
                    }
                }
            }
            DBConnection.closeConnection();
        }

        private void EditCustomerSubmitButton_Click(object sender, EventArgs e)
        {
            CheckForValidDataEntry();
            UpdateCustomerInfo(receivedCustomerId);
            this.Close();
        }

        private void CheckForValidDataEntry()
        {
            // Valid Name Check
            if (EditCustomerNameTextBox.Text == "")
            {
                MessageBox.Show("Customer name entry is required.");
                return;
            }

            // Valid Address Check
            if (EditCustomerAddressTextBox.Text == "")
            {
                MessageBox.Show("Customer address entry is required.");
                return;
            }

            // Valid Phone Check
            string regexPattern = @"^[\d-]+$"; // Allows only numbers and hyphens
            if (EditCustomerPhoneTextBox.Text == "")
            {
                MessageBox.Show("Customer phone entry is required.");
                return;
            }
            else if (!Regex.IsMatch(EditCustomerPhoneTextBox.Text, regexPattern))
            {
                MessageBox.Show("Customer phone number can only have numbers and hyphens.");
                return;
            }

            // Valid City Check
            if (EditCustomerCityTextBox.Text == "")
            {
                MessageBox.Show("Customer city entry is required.");
                return;
            }

            // Valid Country Check
            if (EditCustomerCountryTextBox.Text == "")
            {
                MessageBox.Show("Customer country entry is required.");
                return;
            }
        }

        private void UpdateCustomerInfo(int customerId)
        {
            string updateCustomerQuery = "UPDATE customer SET customerName = @customerName WHERE customerId = @customerId";

            string updateAddressQuery = "UPDATE address SET address = @address, phone = @phone WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)";

            string updateCityQuery = "UPDATE city SET city = @city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId))";

            string updateCountryQuery = "UPDATE country SET country = @country WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)))";

            DBConnection.startConnection();
            using (MySqlCommand connection = new MySqlCommand("",DBConnection.conn))
            {
                // SqlTransaction ensures all updates succeed or all fail
                MySqlTransaction transaction = connection.Connection.BeginTransaction();

                try
                {
                    // Update Customer
                    using (MySqlCommand cmd = new MySqlCommand(updateCustomerQuery, DBConnection.conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@customerName", EditCustomerNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
;                    }

                    // Update Address
                    using (MySqlCommand cmd = new MySqlCommand(updateAddressQuery, DBConnection.conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@address", EditCustomerAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@phone", EditCustomerPhoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update City
                    using (MySqlCommand cmd = new MySqlCommand(updateCityQuery, DBConnection.conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@city", EditCustomerCityTextBox.Text);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update Country
                    using (MySqlCommand cmd = new MySqlCommand(updateCountryQuery, DBConnection.conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@country", EditCustomerCountryTextBox.Text);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Error occurred when trying to update the customer");
                }
            }
            DBConnection.closeConnection();
            MessageBox.Show("Customer successfully updated.");
        }

        private void EditCustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
