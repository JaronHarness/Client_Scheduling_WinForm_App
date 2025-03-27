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

namespace C969.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCustomerDGV();
        }

        private void MainAddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomerFormInstance = new AddCustomer();
            newAddCustomerFormInstance.FormClosed += newAddCustomerFormInstance_FormClosed;
            newAddCustomerFormInstance.ShowDialog();
        }

        private void newAddCustomerFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomerDGV();
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainCustomerDGV.ClearSelection();
        }

        // Methods

        private void LoadCustomerDGV()
        {
            string customerDGVQuery = "SELECT customer.customerName, address.address, address.phone, city.city, country.country FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";

            DBConnection.startConnection();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(customerDGVQuery,DBConnection.conn);
            DataTable customerDT = new DataTable();
            sqlDataAdapter.Fill(customerDT);
            MainCustomerDGV.DataSource = customerDT;

            DBConnection.closeConnection();
        }
    }
}
