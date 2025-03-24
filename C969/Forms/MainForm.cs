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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainAddCustomerButton_Click(object sender, EventArgs e)
        {
            var newAddCustomerFormInstance = new AddCustomer();
            newAddCustomerFormInstance.Show();
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
