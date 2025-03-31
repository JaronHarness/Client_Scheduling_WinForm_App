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
        private DataTable receivedReportData;
        public AppointmentTypesByMonth(DataTable reportData)
        {
            receivedReportData = reportData;
            InitializeComponent();
            AppointmentTypesByMonthDGV.DataSource = receivedReportData;
        }

        private void MyDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AppointmentTypesByMonthDGV.ClearSelection();
        }

        private void AppointmentTypesByMonthCloseReportButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
