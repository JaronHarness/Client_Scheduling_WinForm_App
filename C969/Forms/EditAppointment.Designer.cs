namespace C969.Forms
{
    partial class EditAppointment
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
            this.EditAppointmentTitleLabel = new System.Windows.Forms.Label();
            this.EditAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.EditAppointmentCustomerLabel = new System.Windows.Forms.Label();
            this.EditAppointmentStartLabel = new System.Windows.Forms.Label();
            this.EditAppointmentEndLabel = new System.Windows.Forms.Label();
            this.EditAppointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.EditAppointmentSubmitButton = new System.Windows.Forms.Button();
            this.EditAppointmentCancelButton = new System.Windows.Forms.Button();
            this.EditAppointmentCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.EditAppointmentStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditAppointmentEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // EditAppointmentTitleLabel
            // 
            this.EditAppointmentTitleLabel.AutoSize = true;
            this.EditAppointmentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.EditAppointmentTitleLabel.Name = "EditAppointmentTitleLabel";
            this.EditAppointmentTitleLabel.Size = new System.Drawing.Size(132, 20);
            this.EditAppointmentTitleLabel.TabIndex = 0;
            this.EditAppointmentTitleLabel.Text = "Edit Appointment";
            // 
            // EditAppointmentTypeLabel
            // 
            this.EditAppointmentTypeLabel.AutoSize = true;
            this.EditAppointmentTypeLabel.Location = new System.Drawing.Point(13, 49);
            this.EditAppointmentTypeLabel.Name = "EditAppointmentTypeLabel";
            this.EditAppointmentTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.EditAppointmentTypeLabel.TabIndex = 1;
            this.EditAppointmentTypeLabel.Text = "Type";
            // 
            // EditAppointmentCustomerLabel
            // 
            this.EditAppointmentCustomerLabel.AutoSize = true;
            this.EditAppointmentCustomerLabel.Location = new System.Drawing.Point(13, 88);
            this.EditAppointmentCustomerLabel.Name = "EditAppointmentCustomerLabel";
            this.EditAppointmentCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.EditAppointmentCustomerLabel.TabIndex = 2;
            this.EditAppointmentCustomerLabel.Text = "Customer";
            // 
            // EditAppointmentStartLabel
            // 
            this.EditAppointmentStartLabel.AutoSize = true;
            this.EditAppointmentStartLabel.Location = new System.Drawing.Point(13, 129);
            this.EditAppointmentStartLabel.Name = "EditAppointmentStartLabel";
            this.EditAppointmentStartLabel.Size = new System.Drawing.Size(29, 13);
            this.EditAppointmentStartLabel.TabIndex = 3;
            this.EditAppointmentStartLabel.Text = "Start";
            // 
            // EditAppointmentEndLabel
            // 
            this.EditAppointmentEndLabel.AutoSize = true;
            this.EditAppointmentEndLabel.Location = new System.Drawing.Point(13, 170);
            this.EditAppointmentEndLabel.Name = "EditAppointmentEndLabel";
            this.EditAppointmentEndLabel.Size = new System.Drawing.Size(26, 13);
            this.EditAppointmentEndLabel.TabIndex = 4;
            this.EditAppointmentEndLabel.Text = "End";
            // 
            // EditAppointmentTypeTextBox
            // 
            this.EditAppointmentTypeTextBox.Location = new System.Drawing.Point(82, 46);
            this.EditAppointmentTypeTextBox.Name = "EditAppointmentTypeTextBox";
            this.EditAppointmentTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.EditAppointmentTypeTextBox.TabIndex = 5;
            // 
            // EditAppointmentSubmitButton
            // 
            this.EditAppointmentSubmitButton.Location = new System.Drawing.Point(54, 213);
            this.EditAppointmentSubmitButton.Name = "EditAppointmentSubmitButton";
            this.EditAppointmentSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentSubmitButton.TabIndex = 9;
            this.EditAppointmentSubmitButton.Text = "Submit";
            this.EditAppointmentSubmitButton.UseVisualStyleBackColor = true;
            this.EditAppointmentSubmitButton.Click += new System.EventHandler(this.EditAppointmentSubmitButton_Click);
            // 
            // EditAppointmentCancelButton
            // 
            this.EditAppointmentCancelButton.Location = new System.Drawing.Point(182, 213);
            this.EditAppointmentCancelButton.Name = "EditAppointmentCancelButton";
            this.EditAppointmentCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentCancelButton.TabIndex = 10;
            this.EditAppointmentCancelButton.Text = "Cancel";
            this.EditAppointmentCancelButton.UseVisualStyleBackColor = true;
            this.EditAppointmentCancelButton.Click += new System.EventHandler(this.EditAppointmentCancelButton_Click);
            // 
            // EditAppointmentCustomerComboBox
            // 
            this.EditAppointmentCustomerComboBox.FormattingEnabled = true;
            this.EditAppointmentCustomerComboBox.Location = new System.Drawing.Point(82, 85);
            this.EditAppointmentCustomerComboBox.Name = "EditAppointmentCustomerComboBox";
            this.EditAppointmentCustomerComboBox.Size = new System.Drawing.Size(200, 21);
            this.EditAppointmentCustomerComboBox.TabIndex = 11;
            // 
            // EditAppointmentStartDateTimePicker
            // 
            this.EditAppointmentStartDateTimePicker.CustomFormat = "\"MM/dd/yyy hh:mm tt\"";
            this.EditAppointmentStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditAppointmentStartDateTimePicker.Location = new System.Drawing.Point(82, 123);
            this.EditAppointmentStartDateTimePicker.Name = "EditAppointmentStartDateTimePicker";
            this.EditAppointmentStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EditAppointmentStartDateTimePicker.TabIndex = 12;
            // 
            // EditAppointmentEndDateTimePicker
            // 
            this.EditAppointmentEndDateTimePicker.CustomFormat = "\"MM/dd/yyy hh:mm tt\"";
            this.EditAppointmentEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditAppointmentEndDateTimePicker.Location = new System.Drawing.Point(82, 164);
            this.EditAppointmentEndDateTimePicker.Name = "EditAppointmentEndDateTimePicker";
            this.EditAppointmentEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EditAppointmentEndDateTimePicker.TabIndex = 13;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 273);
            this.Controls.Add(this.EditAppointmentEndDateTimePicker);
            this.Controls.Add(this.EditAppointmentStartDateTimePicker);
            this.Controls.Add(this.EditAppointmentCustomerComboBox);
            this.Controls.Add(this.EditAppointmentCancelButton);
            this.Controls.Add(this.EditAppointmentSubmitButton);
            this.Controls.Add(this.EditAppointmentTypeTextBox);
            this.Controls.Add(this.EditAppointmentEndLabel);
            this.Controls.Add(this.EditAppointmentStartLabel);
            this.Controls.Add(this.EditAppointmentCustomerLabel);
            this.Controls.Add(this.EditAppointmentTypeLabel);
            this.Controls.Add(this.EditAppointmentTitleLabel);
            this.Name = "EditAppointment";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditAppointmentTitleLabel;
        private System.Windows.Forms.Label EditAppointmentTypeLabel;
        private System.Windows.Forms.Label EditAppointmentCustomerLabel;
        private System.Windows.Forms.Label EditAppointmentStartLabel;
        private System.Windows.Forms.Label EditAppointmentEndLabel;
        private System.Windows.Forms.TextBox EditAppointmentTypeTextBox;
        private System.Windows.Forms.Button EditAppointmentSubmitButton;
        private System.Windows.Forms.Button EditAppointmentCancelButton;
        private System.Windows.Forms.ComboBox EditAppointmentCustomerComboBox;
        private System.Windows.Forms.DateTimePicker EditAppointmentStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EditAppointmentEndDateTimePicker;
    }
}