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
        }

        private void myDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ScheduleByUserDGV.ClearSelection();
        }

        private void SchedultByUserCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
