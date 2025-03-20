using C969.Database;
using C969.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBConnection.startConnection();
            // Closes Login form after successful Log In attempt without closing the program
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
            DBConnection.closeConnection();
        }
    }
}
