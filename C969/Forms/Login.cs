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
using System.IO;

namespace C969
{
    public partial class Login: Form
    {

        private readonly string logFilePath = Path.Combine(Environment.CurrentDirectory,"..\\..\\Login_History.txt");

        public Login()
        {
            InitializeComponent();
            LanguageSelect();
            AdjustUsernameTextBoxLocation();
        }

        private void AdjustUsernameTextBoxLocation()
        {
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("es"))
            {
                LoginFormUsernameLabel.Location = new System.Drawing.Point(LoginFormUsernameLabel.Location.X - 30, LoginFormUsernameLabel.Location.Y);

                LoginFormPasswordLabel.Location = new System.Drawing.Point(LoginFormPasswordLabel.Location.X - 30, LoginFormPasswordLabel.Location.Y);
            }
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

        private void AppointmentAlertsCheck(int userId)
        {
            string alertQuery = "SELECT appointmentId, start FROM appointment WHERE userId = @userId AND start >= NOW() AND start <= DATE_ADD(NOW(), INTERVAL 15 MINUTE)";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(alertQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int appointmentId = Convert.ToInt32(reader["appointmentId"]);
                            DateTime appointmentStart = Convert.ToDateTime(reader["start"]);

                            MessageBox.Show($"You have an upcoming appointment:\n" +
                                $"Appointment ID: {appointmentId}\n" +
                                $"Start Time: {appointmentStart}", 
                                "Upcoming Appointment Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
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

            // Username not entered
            if (LoginFormUsernameTextBox.Text == "" && CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("en"))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (LoginFormUsernameTextBox.Text == "" && CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("es"))
            {
                MessageBox.Show("Por favor, introduzca un nombre de usuario.");
                return;
            }

            // Password not entered
            if (LoginFormPasswordTextBox.Text == "" && CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("en"))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (LoginFormPasswordTextBox.Text == "" && CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("es"))
            {
                MessageBox.Show("Por favor, introduzca una contraseña.");
                return;
            }

            if (LoginFormUsernameTextBox.Text != null)
            {
                GlobalVariables.loggedInUser = LoginFormUsernameTextBox.Text;
            }

            string userIdQuery = "SELECT userId FROM user WHERE userName = @userName AND password = @password";

            DBConnection.startConnection();
            using (MySqlCommand cmd = new MySqlCommand(userIdQuery, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userName",usernameInput);
                cmd.Parameters.AddWithValue("@password", passwordInput);

                object userIdResult = cmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    GlobalVariables.LoggedInUserId = Convert.ToInt32(userIdResult);
                }
            }
            DBConnection.closeConnection();

            RecordLoginHistory(usernameInput);

            AppointmentAlertsCheck(GlobalVariables.LoggedInUserId);

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
                        if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("en"))
                        {
                            MessageBox.Show("The username and password did not match.");
                            return;
                        }
                        if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Contains("es"))
                        {
                            MessageBox.Show("El nombre de usuario y la contraseña no coincidían");
                            return;
                        }
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

        private void RecordLoginHistory(string userName)
        {
            DateTime timestamp = DateTime.Now;

            string logEntry = $"{userName} logged in at {timestamp:G}.";

            using (FileStream fs = new FileStream(logFilePath, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(logEntry);
            }
        }
    }
}
