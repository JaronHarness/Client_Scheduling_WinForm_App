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
using C969.Global;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace C969.Forms
{
    public partial class AddCustomer : Form
    {
        int outputCountryId;
        int outputCityId;
        int outputAddressId;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCustomerSubmitButton_Click(object sender, EventArgs e)
        {
            // Assign user input to variables
            string nameInput;
            string addressInput;
            string phoneInput;
            string cityInput;
            string countryInput;

            // Defaults values
            string createDateInput = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string lastUpdateInput = createDateInput;
            string postalCodeInput = "00000";
            string address2Input = "N/A";
            string createdByInput = GlobalVariables.loggedInUser;
            string lastUpdateByInput = GlobalVariables.loggedInUser;

            // Valid Name Check
            if (AddCustomerNameTextBox.Text == "")
            {
                MessageBox.Show("Customer name entry is required.");
                return;
            }
            else
            {
                nameInput = AddCustomerNameTextBox.Text;
            }
            // Valid Address Check
            if (AddCustomerAddressTextBox.Text == "")
            {
                MessageBox.Show("Customer address entry is required.");
                return;
            }
            else
            {
                addressInput = AddCustomerAddressTextBox.Text;
            }
            // Valid Phone Check
            string regexPattern = @"^[\d-]+$"; // Allows only numbers and hyphens
            if (AddCustomerPhoneTextBox.Text == "")
            {
                MessageBox.Show("Customer phone entry is required.");
                return;
            }
            else if (!Regex.IsMatch(AddCustomerPhoneTextBox.Text, regexPattern))
            {
                MessageBox.Show("Customer phone number can only have numbers and hyphens.");
                return;
            }
            else
            {
                phoneInput = AddCustomerPhoneTextBox.Text;
            }
            // Valid City Check
            if (AddCustomerCityTextBox.Text == "")
            {
                MessageBox.Show("Customer city entry is required.");
                return;
            }
            else
            {
                cityInput = AddCustomerCityTextBox.Text;
            }
            // Valid Country Check
            if (AddCustomerCountryTextBox.Text == "")
            {
                MessageBox.Show("Customer country entry is required.");
                return;
            }
            else
            {
                countryInput = AddCustomerCountryTextBox.Text;
            }

            if (!DoesCountryExist(countryInput))
            {
                AddCountry(countryInput, createDateInput, createdByInput,lastUpdateInput,lastUpdateByInput);
            }
            if (!DoesCityExist(cityInput, outputCountryId))
            {
                AddCity(cityInput, outputCountryId,  createDateInput, createdByInput, lastUpdateInput, lastUpdateByInput);
            }
            AddAddress(addressInput, address2Input, outputCityId, postalCodeInput, phoneInput, createDateInput, createdByInput, lastUpdateInput, lastUpdateByInput);
            AddTheCustomer(nameInput, outputAddressId, createDateInput, createdByInput, lastUpdateInput, lastUpdateByInput);
        }

        public bool DoesCountryExist(string countryInput)
        {
            bool countryExist = false;
            
            string countryQuery = "SELECT countryID FROM country WHERE country = @country";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(countryQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@country", countryInput);

                int numOfCountryInDB = Convert.ToInt32(cmd.ExecuteScalar());

                object resultObj = cmd.ExecuteScalar();
                outputCountryId = Convert.ToInt32(resultObj);

                // Country Exists
                if (numOfCountryInDB > 0)
                {
                    countryExist = true;
                }


            }
            DBConnection.closeConnection();
            return countryExist;
        }

        public void AddCountry(string countryInput, string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdateByInput)
        {
            string addCountryQuery = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy); SELECT LAST_INSERT_ID();";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addCountryQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@country", countryInput);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateByInput);

                outputCountryId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            DBConnection.closeConnection();

        }

        public bool DoesCityExist(string cityInput, int countryId)
        {
            bool cityExist = false;

            string cityQuery = "SELECT cityID FROM city WHERE city = @city AND countryId = @countryId";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(cityQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@city", cityInput);
                cmd.Parameters.AddWithValue("@countryId", countryId);

                int numOfCityInDB = Convert.ToInt32(cmd.ExecuteScalar());

                object resultObj = cmd.ExecuteScalar();
                outputCityId = Convert.ToInt32(resultObj);

                // City Exists
                if (numOfCityInDB > 0)
                {
                    cityExist = true;
                }


            }
            DBConnection.closeConnection();
            return cityExist;
        }

        public void AddCity(string cityInput, int outputCountryId,string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdateByInput)
        {
            string addCityQuery = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy); SELECT LAST_INSERT_ID();";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addCityQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@city", cityInput);
                cmd.Parameters.AddWithValue("@countryId", outputCountryId);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateByInput);

                outputCityId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            DBConnection.closeConnection();
        }

        public void AddAddress(string addressInput, string address2Input, int outputCityId, string postalCodeInput, string phoneInput, string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdateByInput)
        {
            string addAddressQuery = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy); SELECT LAST_INSERT_ID();";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addAddressQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@address", addressInput);
                cmd.Parameters.AddWithValue("@address2", address2Input);
                cmd.Parameters.AddWithValue("@cityId", outputCityId);
                cmd.Parameters.AddWithValue("@postalCode", postalCodeInput);
                cmd.Parameters.AddWithValue("@phone", phoneInput);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateByInput);

                outputAddressId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            DBConnection.closeConnection();
        }

        public void AddTheCustomer(string nameInput, int outputAddressId, string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdateByInput)
        {
            string addCustomerQuery = "INSERT INTO customer (customerName, addressId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName, @addressId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addCustomerQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@customerName", nameInput);
                cmd.Parameters.AddWithValue("@addressId", outputAddressId);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateByInput);
            }
            DBConnection.closeConnection();
        }
    }
}
