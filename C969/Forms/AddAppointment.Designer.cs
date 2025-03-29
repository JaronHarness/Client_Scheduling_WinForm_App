namespace C969.Forms
{
    partial class AddAppointment
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
            this.AddAppointmentTitleLabel = new System.Windows.Forms.Label();
            this.AddAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.AddAppointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentCustomerLabel = new System.Windows.Forms.Label();
            this.AddAppointmentCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.AddAppointmentStartLabel = new System.Windows.Forms.Label();
            this.AddAppointmentEndLabel = new System.Windows.Forms.Label();
            this.AddAppointmentStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAppointmentEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAppointmentSubmitButton = new System.Windows.Forms.Button();
            this.AddAppointmentCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAppointmentTitleLabel
            // 
            this.AddAppointmentTitleLabel.AutoSize = true;
            this.AddAppointmentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.AddAppointmentTitleLabel.Name = "AddAppointmentTitleLabel";
            this.AddAppointmentTitleLabel.Size = new System.Drawing.Size(133, 20);
            this.AddAppointmentTitleLabel.TabIndex = 0;
            this.AddAppointmentTitleLabel.Text = "Add Appointment";
            // 
            // AddAppointmentTypeLabel
            // 
            this.AddAppointmentTypeLabel.AutoSize = true;
            this.AddAppointmentTypeLabel.Location = new System.Drawing.Point(13, 54);
            this.AddAppointmentTypeLabel.Name = "AddAppointmentTypeLabel";
            this.AddAppointmentTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.AddAppointmentTypeLabel.TabIndex = 1;
            this.AddAppointmentTypeLabel.Text = "Type";
            // 
            // AddAppointmentTypeTextBox
            // 
            this.AddAppointmentTypeTextBox.Location = new System.Drawing.Point(80, 51);
            this.AddAppointmentTypeTextBox.Name = "AddAppointmentTypeTextBox";
            this.AddAppointmentTypeTextBox.Size = new System.Drawing.Size(198, 20);
            this.AddAppointmentTypeTextBox.TabIndex = 2;
            // 
            // AddAppointmentCustomerLabel
            // 
            this.AddAppointmentCustomerLabel.AutoSize = true;
            this.AddAppointmentCustomerLabel.Location = new System.Drawing.Point(13, 99);
            this.AddAppointmentCustomerLabel.Name = "AddAppointmentCustomerLabel";
            this.AddAppointmentCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.AddAppointmentCustomerLabel.TabIndex = 3;
            this.AddAppointmentCustomerLabel.Text = "Customer";
            // 
            // AddAppointmentCustomerComboBox
            // 
            this.AddAppointmentCustomerComboBox.FormattingEnabled = true;
            this.AddAppointmentCustomerComboBox.Location = new System.Drawing.Point(80, 96);
            this.AddAppointmentCustomerComboBox.Name = "AddAppointmentCustomerComboBox";
            this.AddAppointmentCustomerComboBox.Size = new System.Drawing.Size(198, 21);
            this.AddAppointmentCustomerComboBox.TabIndex = 4;
            // 
            // AddAppointmentStartLabel
            // 
            this.AddAppointmentStartLabel.AutoSize = true;
            this.AddAppointmentStartLabel.Location = new System.Drawing.Point(13, 147);
            this.AddAppointmentStartLabel.Name = "AddAppointmentStartLabel";
            this.AddAppointmentStartLabel.Size = new System.Drawing.Size(29, 13);
            this.AddAppointmentStartLabel.TabIndex = 5;
            this.AddAppointmentStartLabel.Text = "Start";
            // 
            // AddAppointmentEndLabel
            // 
            this.AddAppointmentEndLabel.AutoSize = true;
            this.AddAppointmentEndLabel.Location = new System.Drawing.Point(13, 193);
            this.AddAppointmentEndLabel.Name = "AddAppointmentEndLabel";
            this.AddAppointmentEndLabel.Size = new System.Drawing.Size(26, 13);
            this.AddAppointmentEndLabel.TabIndex = 6;
            this.AddAppointmentEndLabel.Text = "End";
            // 
            // AddAppointmentStartDateTimePicker
            // 
            this.AddAppointmentStartDateTimePicker.CustomFormat = "\"MM/dd/yyy hh:mm tt\"";
            this.AddAppointmentStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddAppointmentStartDateTimePicker.Location = new System.Drawing.Point(80, 141);
            this.AddAppointmentStartDateTimePicker.Name = "AddAppointmentStartDateTimePicker";
            this.AddAppointmentStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentStartDateTimePicker.TabIndex = 7;
            // 
            // AddAppointmentEndDateTimePicker
            // 
            this.AddAppointmentEndDateTimePicker.CustomFormat = "\"MM/dd/yyy hh:mm tt\"";
            this.AddAppointmentEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddAppointmentEndDateTimePicker.Location = new System.Drawing.Point(80, 187);
            this.AddAppointmentEndDateTimePicker.Name = "AddAppointmentEndDateTimePicker";
            this.AddAppointmentEndDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.AddAppointmentEndDateTimePicker.TabIndex = 8;
            // 
            // AddAppointmentSubmitButton
            // 
            this.AddAppointmentSubmitButton.Location = new System.Drawing.Point(44, 226);
            this.AddAppointmentSubmitButton.Name = "AddAppointmentSubmitButton";
            this.AddAppointmentSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentSubmitButton.TabIndex = 9;
            this.AddAppointmentSubmitButton.Text = "Submit";
            this.AddAppointmentSubmitButton.UseVisualStyleBackColor = true;
            this.AddAppointmentSubmitButton.Click += new System.EventHandler(this.AddAppointmentSubmitButton_Click);
            // 
            // AddAppointmentCancelButton
            // 
            this.AddAppointmentCancelButton.Location = new System.Drawing.Point(164, 226);
            this.AddAppointmentCancelButton.Name = "AddAppointmentCancelButton";
            this.AddAppointmentCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentCancelButton.TabIndex = 10;
            this.AddAppointmentCancelButton.Text = "Cancel";
            this.AddAppointmentCancelButton.UseVisualStyleBackColor = true;
            this.AddAppointmentCancelButton.Click += new System.EventHandler(this.AddAppointmentCancelButton_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 274);
            this.Controls.Add(this.AddAppointmentCancelButton);
            this.Controls.Add(this.AddAppointmentSubmitButton);
            this.Controls.Add(this.AddAppointmentEndDateTimePicker);
            this.Controls.Add(this.AddAppointmentStartDateTimePicker);
            this.Controls.Add(this.AddAppointmentEndLabel);
            this.Controls.Add(this.AddAppointmentStartLabel);
            this.Controls.Add(this.AddAppointmentCustomerComboBox);
            this.Controls.Add(this.AddAppointmentCustomerLabel);
            this.Controls.Add(this.AddAppointmentTypeTextBox);
            this.Controls.Add(this.AddAppointmentTypeLabel);
            this.Controls.Add(this.AddAppointmentTitleLabel);
            this.Name = "AddAppointment";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddAppointmentTitleLabel;
        private System.Windows.Forms.Label AddAppointmentTypeLabel;
        private System.Windows.Forms.TextBox AddAppointmentTypeTextBox;
        private System.Windows.Forms.Label AddAppointmentCustomerLabel;
        private System.Windows.Forms.ComboBox AddAppointmentCustomerComboBox;
        private System.Windows.Forms.Label AddAppointmentStartLabel;
        private System.Windows.Forms.Label AddAppointmentEndLabel;
        private System.Windows.Forms.DateTimePicker AddAppointmentStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker AddAppointmentEndDateTimePicker;
        private System.Windows.Forms.Button AddAppointmentSubmitButton;
        private System.Windows.Forms.Button AddAppointmentCancelButton;
    }
}