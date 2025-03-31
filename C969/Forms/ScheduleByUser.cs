using C969.Database;
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

namespace C969.Forms
{
    public partial class ScheduleByUser : Form
    {
        public ScheduleByUser()
        {
            InitializeComponent();
            DisplayReport();
        }

        private void myDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ScheduleByUserDGV.ClearSelection();
        }

        private void SchedultByUserCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable RetrieveUserReport()
        {
            int userId = GlobalVariables.LoggedInUserId;

            string reportQuery = @"SELECT * FROM appointment WHERE userId = @userId ORDER BY start";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(reportQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);

                    foreach (DataRow row in reportData.Rows)
                    {
                        DateTime startUTC = Convert.ToDateTime(row["start"]);
                        DateTime endUTC = Convert.ToDateTime(row["end"]);

                        row["start"] = startUTC.ToLocalTime();
                        row["end"] = endUTC.ToLocalTime();
                    }

                    return reportData;
                }
            }
        }

        private void DisplayReport()
        {
            ScheduleByUserDGV.DataSource = RetrieveUserReport();

            // Lambda expression to hide unwanted columns
            Action<string> hideColumn = columnName =>
            {
                ScheduleByUserDGV.Columns[columnName].Visible = false;
            };

            hideColumn("title");
            hideColumn("description");
            hideColumn("location");
            hideColumn("contact");
            hideColumn("url");
            hideColumn("lastUpdate");
            hideColumn("lastUpdateBy");
        }
    }
}
