using C969.Global;
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

namespace C969.Forms
{
    public partial class NumberOfUsers : Form
    {
        public NumberOfUsers()
        {
            InitializeComponent();
            NumberOfUsersDGV.DataSource = DisplayReport();
            NumberOfUsersDGV.Columns["NumberOfUsers"].HeaderText = "Total Number of Users";
        }

        private DataTable DisplayReport()
        {
            string reportQuery = "SELECT COUNT(*) AS NumberOfUsers FROM user";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(reportQuery, DBConnection.conn))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable userCountData = new DataTable();
                    adapter.Fill(userCountData);
                    return userCountData;
                }
            }
        }

        private void myDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            NumberOfUsersDGV.ClearSelection();
        }

        private void NumberOfUsersCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
