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

namespace C969
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            LanguageSelect();
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
    }
}
