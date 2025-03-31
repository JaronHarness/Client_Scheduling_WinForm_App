using C969.Database;
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

namespace C969.Forms
{
    public partial class AppointmentTypesByMonth : Form
    {
        public AppointmentTypesByMonth()
        {
            InitializeComponent();
            DisplayReport();
        }

        private void MyDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AppointmentTypesByMonthDGV.ClearSelection();
        }

        private void AppointmentTypesByMonthCloseReportButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayReport()
        {
            DataTable dataTable = new DataTable();

            string reportQuery = "SELECT MONTHNAME(start) AS month, type, COUNT(type) AS typeCount FROM appointment GROUP BY type, month ORDER BY typeCount;";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(reportQuery, DBConnection.conn))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            DBConnection.closeConnection();

            AppointmentTypesByMonthDGV.DataSource = dataTable;

            ColumnNameDisplay(AppointmentTypesByMonthDGV, "month", "Month");
            ColumnNameDisplay(AppointmentTypesByMonthDGV, "type", "Type");
            ColumnNameDisplay(AppointmentTypesByMonthDGV, "typeCount", "Count");
        }
        private void ColumnNameDisplay(DataGridView dgv, string oldName, string newName)
        {
            dgv.Columns[oldName].HeaderText = newName;
        }
    }
}
