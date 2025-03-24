using C969.Database;
using C969.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.Global;

namespace C969
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            LanguageSelect();
            //Test
        }

        private void LanguageSelect()
        {
            // Spanish
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("es"))
            {
                LoginFormTitleLabel.Text = "Acceso";
                LoginFormUsernameLabel.Text = "Nombre de usuario";
                LoginFormPasswordLabel.Text = "Contraseña";
                LoginFormLoginButton.Text = "Acceso";
                LoginFormExitButton.Text = "Salida";
            }
            // English
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("en"))
            {
                LoginFormTitleLabel.Text = "Log In";
                LoginFormUsernameLabel.Text = "Username";
                LoginFormPasswordLabel.Text = "Password";
                LoginFormLoginButton.Text = "Log In";
                LoginFormExitButton.Text = "Exit";
            }
        }

        private void LoginFormExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginFormLoginButton_Click(object sender, EventArgs e)
        {
            string usernameInput = LoginFormUsernameTextBox.Text.Trim();
            string passwordInput = LoginFormPasswordTextBox.Text.Trim();

            if (LoginFormUsernameTextBox.Text != null)
            {
                GlobalVariables.loggedInUser = LoginFormUsernameTextBox.Text;
            }

            string getUserQuery = $"SELECT COUNT(1) FROM user WHERE userName = '{usernameInput}' AND password = '{passwordInput}'";

            try
            {
                DBConnection.startConnection();
                using (MySqlCommand cmd = new MySqlCommand(getUserQuery, DBConnection.conn))
                {
                    cmd.Parameters.AddWithValue("@userName", usernameInput);
                    cmd.Parameters.AddWithValue("@password", passwordInput);

                    int numOfUserInDB = Convert.ToInt32(cmd.ExecuteScalar());

                    if (numOfUserInDB == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.closeConnection();
            }

        }
    }
}
