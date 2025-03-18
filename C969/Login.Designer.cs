namespace C969
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginFormUsernameLabel = new System.Windows.Forms.Label();
            this.LoginFormPasswordLabel = new System.Windows.Forms.Label();
            this.LoginFormUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormLoginButton = new System.Windows.Forms.Button();
            this.LoginFormExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginFormUsernameLabel
            // 
            this.LoginFormUsernameLabel.AutoSize = true;
            this.LoginFormUsernameLabel.Location = new System.Drawing.Point(58, 50);
            this.LoginFormUsernameLabel.Name = "LoginFormUsernameLabel";
            this.LoginFormUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.LoginFormUsernameLabel.TabIndex = 0;
            this.LoginFormUsernameLabel.Text = "Username";
            // 
            // LoginFormPasswordLabel
            // 
            this.LoginFormPasswordLabel.AutoSize = true;
            this.LoginFormPasswordLabel.Location = new System.Drawing.Point(60, 99);
            this.LoginFormPasswordLabel.Name = "LoginFormPasswordLabel";
            this.LoginFormPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.LoginFormPasswordLabel.TabIndex = 1;
            this.LoginFormPasswordLabel.Text = "Password";
            // 
            // LoginFormUsernameTextBox
            // 
            this.LoginFormUsernameTextBox.Location = new System.Drawing.Point(140, 47);
            this.LoginFormUsernameTextBox.Name = "LoginFormUsernameTextBox";
            this.LoginFormUsernameTextBox.Size = new System.Drawing.Size(158, 20);
            this.LoginFormUsernameTextBox.TabIndex = 2;
            // 
            // LoginFormPasswordTextBox
            // 
            this.LoginFormPasswordTextBox.Location = new System.Drawing.Point(140, 96);
            this.LoginFormPasswordTextBox.Name = "LoginFormPasswordTextBox";
            this.LoginFormPasswordTextBox.Size = new System.Drawing.Size(158, 20);
            this.LoginFormPasswordTextBox.TabIndex = 3;
            // 
            // LoginFormLoginButton
            // 
            this.LoginFormLoginButton.Location = new System.Drawing.Point(140, 144);
            this.LoginFormLoginButton.Name = "LoginFormLoginButton";
            this.LoginFormLoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginFormLoginButton.TabIndex = 4;
            this.LoginFormLoginButton.Text = "Log In";
            this.LoginFormLoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginFormExitButton
            // 
            this.LoginFormExitButton.Location = new System.Drawing.Point(321, 337);
            this.LoginFormExitButton.Name = "LoginFormExitButton";
            this.LoginFormExitButton.Size = new System.Drawing.Size(75, 23);
            this.LoginFormExitButton.TabIndex = 5;
            this.LoginFormExitButton.Text = "Exit";
            this.LoginFormExitButton.UseVisualStyleBackColor = true;
            this.LoginFormExitButton.Click += new System.EventHandler(this.LoginFormExitButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 372);
            this.Controls.Add(this.LoginFormExitButton);
            this.Controls.Add(this.LoginFormLoginButton);
            this.Controls.Add(this.LoginFormPasswordTextBox);
            this.Controls.Add(this.LoginFormUsernameTextBox);
            this.Controls.Add(this.LoginFormPasswordLabel);
            this.Controls.Add(this.LoginFormUsernameLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginFormUsernameLabel;
        private System.Windows.Forms.Label LoginFormPasswordLabel;
        private System.Windows.Forms.TextBox LoginFormUsernameTextBox;
        private System.Windows.Forms.TextBox LoginFormPasswordTextBox;
        private System.Windows.Forms.Button LoginFormLoginButton;
        private System.Windows.Forms.Button LoginFormExitButton;
    }
}

