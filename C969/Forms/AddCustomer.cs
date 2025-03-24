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

namespace C969.Forms
{
    public partial class AddCustomer : Form
    {
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
            string nameInput = AddCustomerNameTextBox.Text;
            string addressInput = AddCustomerAddressTextBox.Text;
            string phoneInput = AddCustomerPhoneTextBox.Text;
            string cityInput = AddCustomerCityTextBox.Text;
            string countryInput = AddCustomerCountryTextBox.Text;

            // Defaults values
            string createDateInput = DateTime.Now.ToString("D");
            string lastUpdateInput = createDateInput;
            string postalCodeInput = "00000";
            string address2Input = "N/A";
            string createdByInput = GlobalVariables.loggedInUser;
            string lastUpdatedByInput = GlobalVariables.loggedInUser;

            // A Customer Logic
            if (!DoesCountryExist(countryInput))
            {
                AddCountry(countryInput, createDateInput, createdByInput,lastUpdateInput,lastUpdatedByInput);
            }
        }

        public bool DoesCountryExist(string countryInput)
        {
            bool countryExist = false;

            string countryQuery = "SELECT countryID FROM country WHERE country = @countryInput";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(countryQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@country", countryInput);

                int numOfCountryInDB = Convert.ToInt32(cmd.ExecuteScalar());

                // Country Exists
                if (numOfCountryInDB > 0)
                {
                    countryExist = true;
                }


            }
            DBConnection.closeConnection();
            return countryExist;
        }

        public void AddCountry(string countryInput, string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdatedByInput)
        {
            string addCountryQuery = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy)";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addCountryQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@country", countryInput);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdatedBy", lastUpdatedByInput);
            }
            DBConnection.closeConnection();

        }

        public bool DoesCityExist(string cityInput, string countryId)
        {
            bool cityExist = false;

            string cityQuery = "SELECT cityID FROM city WHERE city = @cityInput AND countryId = @countryInput";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(cityQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@city", cityInput);
                cmd.Parameters.AddWithValue("@countryId", countryId);

                int numOfCityInDB = Convert.ToInt32(cmd.ExecuteScalar());

                // Country Exists
                if (numOfCityInDB > 0)
                {
                    cityExist = true;
                }


            }
            DBConnection.closeConnection();
            return cityExist;
        }

        public void AddCity(string cityInput, string countryId,string createDateInput, string createdByInput, string lastUpdateInput, string lastUpdatedByInput)
        {
            string addCityQuery = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(addCityQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@city", cityInput);
                cmd.Parameters.AddWithValue("@countryId", countryId);
                cmd.Parameters.AddWithValue("@createDate", createDateInput);
                cmd.Parameters.AddWithValue("@createdBy", createdByInput);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdateInput);
                cmd.Parameters.AddWithValue("@lastUpdatedBy", lastUpdatedByInput);
            }
            DBConnection.closeConnection();
        }
    }
}
