namespace C969.Forms
{
    partial class MainForm
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
            this.MainCustomerDGV = new System.Windows.Forms.DataGridView();
            this.MainAddCustomerButton = new System.Windows.Forms.Button();
            this.MainEditCustomerButton = new System.Windows.Forms.Button();
            this.MainDeleteCustomerButton = new System.Windows.Forms.Button();
            this.MainCustomersLabel = new System.Windows.Forms.Label();
            this.MainExitButton = new System.Windows.Forms.Button();
            this.MainAppointmentDGV = new System.Windows.Forms.DataGridView();
            this.MainAddAppointmentButton = new System.Windows.Forms.Button();
            this.MainEditAppointmentButton = new System.Windows.Forms.Button();
            this.MainDeleteAppointmentButton = new System.Windows.Forms.Button();
            this.MainAppointmentsLabel = new System.Windows.Forms.Label();
            this.MainAppointmentMontCalendar = new System.Windows.Forms.MonthCalendar();
            this.MainMonthCalendarResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainCustomerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainAppointmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCustomerDGV
            // 
            this.MainCustomerDGV.AllowUserToAddRows = false;
            this.MainCustomerDGV.AllowUserToDeleteRows = false;
            this.MainCustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainCustomerDGV.Location = new System.Drawing.Point(314, 48);
            this.MainCustomerDGV.MultiSelect = false;
            this.MainCustomerDGV.Name = "MainCustomerDGV";
            this.MainCustomerDGV.ReadOnly = true;
            this.MainCustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainCustomerDGV.Size = new System.Drawing.Size(643, 158);
            this.MainCustomerDGV.TabIndex = 0;
            this.MainCustomerDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // MainAddCustomerButton
            // 
            this.MainAddCustomerButton.Location = new System.Drawing.Point(720, 19);
            this.MainAddCustomerButton.Name = "MainAddCustomerButton";
            this.MainAddCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainAddCustomerButton.TabIndex = 1;
            this.MainAddCustomerButton.Text = "Add";
            this.MainAddCustomerButton.UseVisualStyleBackColor = true;
            this.MainAddCustomerButton.Click += new System.EventHandler(this.MainAddCustomerButton_Click);
            // 
            // MainEditCustomerButton
            // 
            this.MainEditCustomerButton.Location = new System.Drawing.Point(801, 19);
            this.MainEditCustomerButton.Name = "MainEditCustomerButton";
            this.MainEditCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainEditCustomerButton.TabIndex = 2;
            this.MainEditCustomerButton.Text = "Edit";
            this.MainEditCustomerButton.UseVisualStyleBackColor = true;
            this.MainEditCustomerButton.Click += new System.EventHandler(this.MainEditCustomerButton_Click);
            // 
            // MainDeleteCustomerButton
            // 
            this.MainDeleteCustomerButton.Location = new System.Drawing.Point(882, 19);
            this.MainDeleteCustomerButton.Name = "MainDeleteCustomerButton";
            this.MainDeleteCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainDeleteCustomerButton.TabIndex = 3;
            this.MainDeleteCustomerButton.Text = "Delete";
            this.MainDeleteCustomerButton.UseVisualStyleBackColor = true;
            this.MainDeleteCustomerButton.Click += new System.EventHandler(this.MainDeleteCustomerButton_Click);
            // 
            // MainCustomersLabel
            // 
            this.MainCustomersLabel.AutoSize = true;
            this.MainCustomersLabel.Location = new System.Drawing.Point(311, 24);
            this.MainCustomersLabel.Name = "MainCustomersLabel";
            this.MainCustomersLabel.Size = new System.Drawing.Size(56, 13);
            this.MainCustomersLabel.TabIndex = 4;
            this.MainCustomersLabel.Text = "Customers";
            // 
            // MainExitButton
            // 
            this.MainExitButton.Location = new System.Drawing.Point(882, 415);
            this.MainExitButton.Name = "MainExitButton";
            this.MainExitButton.Size = new System.Drawing.Size(75, 23);
            this.MainExitButton.TabIndex = 5;
            this.MainExitButton.Text = "Exit";
            this.MainExitButton.UseVisualStyleBackColor = true;
            this.MainExitButton.Click += new System.EventHandler(this.MainExitButton_Click);
            // 
            // MainAppointmentDGV
            // 
            this.MainAppointmentDGV.AllowUserToAddRows = false;
            this.MainAppointmentDGV.AllowUserToDeleteRows = false;
            this.MainAppointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainAppointmentDGV.Location = new System.Drawing.Point(314, 251);
            this.MainAppointmentDGV.MultiSelect = false;
            this.MainAppointmentDGV.Name = "MainAppointmentDGV";
            this.MainAppointmentDGV.ReadOnly = true;
            this.MainAppointmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainAppointmentDGV.Size = new System.Drawing.Size(643, 158);
            this.MainAppointmentDGV.TabIndex = 6;
            this.MainAppointmentDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete2);
            // 
            // MainAddAppointmentButton
            // 
            this.MainAddAppointmentButton.Location = new System.Drawing.Point(720, 222);
            this.MainAddAppointmentButton.Name = "MainAddAppointmentButton";
            this.MainAddAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.MainAddAppointmentButton.TabIndex = 7;
            this.MainAddAppointmentButton.Text = "Add";
            this.MainAddAppointmentButton.UseVisualStyleBackColor = true;
            this.MainAddAppointmentButton.Click += new System.EventHandler(this.MainAddAppointmentButton_Click);
            // 
            // MainEditAppointmentButton
            // 
            this.MainEditAppointmentButton.Location = new System.Drawing.Point(801, 222);
            this.MainEditAppointmentButton.Name = "MainEditAppointmentButton";
            this.MainEditAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.MainEditAppointmentButton.TabIndex = 8;
            this.MainEditAppointmentButton.Text = "Edit";
            this.MainEditAppointmentButton.UseVisualStyleBackColor = true;
            this.MainEditAppointmentButton.Click += new System.EventHandler(this.MainEditAppointmentButton_Click);
            // 
            // MainDeleteAppointmentButton
            // 
            this.MainDeleteAppointmentButton.Location = new System.Drawing.Point(882, 222);
            this.MainDeleteAppointmentButton.Name = "MainDeleteAppointmentButton";
            this.MainDeleteAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.MainDeleteAppointmentButton.TabIndex = 9;
            this.MainDeleteAppointmentButton.Text = "Delete";
            this.MainDeleteAppointmentButton.UseVisualStyleBackColor = true;
            this.MainDeleteAppointmentButton.Click += new System.EventHandler(this.MainDeleteAppointmentButton_Click);
            // 
            // MainAppointmentsLabel
            // 
            this.MainAppointmentsLabel.AutoSize = true;
            this.MainAppointmentsLabel.Location = new System.Drawing.Point(311, 227);
            this.MainAppointmentsLabel.Name = "MainAppointmentsLabel";
            this.MainAppointmentsLabel.Size = new System.Drawing.Size(71, 13);
            this.MainAppointmentsLabel.TabIndex = 10;
            this.MainAppointmentsLabel.Text = "Appointments";
            // 
            // MainAppointmentMontCalendar
            // 
            this.MainAppointmentMontCalendar.Location = new System.Drawing.Point(42, 247);
            this.MainAppointmentMontCalendar.Name = "MainAppointmentMontCalendar";
            this.MainAppointmentMontCalendar.TabIndex = 11;
            this.MainAppointmentMontCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MainAppointmentMontCalendar_DateSelected);
            // 
            // MainMonthCalendarResetButton
            // 
            this.MainMonthCalendarResetButton.Location = new System.Drawing.Point(194, 415);
            this.MainMonthCalendarResetButton.Name = "MainMonthCalendarResetButton";
            this.MainMonthCalendarResetButton.Size = new System.Drawing.Size(75, 23);
            this.MainMonthCalendarResetButton.TabIndex = 12;
            this.MainMonthCalendarResetButton.Text = "Reset";
            this.MainMonthCalendarResetButton.UseVisualStyleBackColor = true;
            this.MainMonthCalendarResetButton.Click += new System.EventHandler(this.MainMonthCalendarResetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.MainMonthCalendarResetButton);
            this.Controls.Add(this.MainAppointmentMontCalendar);
            this.Controls.Add(this.MainAppointmentsLabel);
            this.Controls.Add(this.MainDeleteAppointmentButton);
            this.Controls.Add(this.MainEditAppointmentButton);
            this.Controls.Add(this.MainAddAppointmentButton);
            this.Controls.Add(this.MainAppointmentDGV);
            this.Controls.Add(this.MainExitButton);
            this.Controls.Add(this.MainCustomersLabel);
            this.Controls.Add(this.MainDeleteCustomerButton);
            this.Controls.Add(this.MainEditCustomerButton);
            this.Controls.Add(this.MainAddCustomerButton);
            this.Controls.Add(this.MainCustomerDGV);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.MainCustomerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainAppointmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainCustomerDGV;
        private System.Windows.Forms.Button MainAddCustomerButton;
        private System.Windows.Forms.Button MainEditCustomerButton;
        private System.Windows.Forms.Button MainDeleteCustomerButton;
        private System.Windows.Forms.Label MainCustomersLabel;
        private System.Windows.Forms.Button MainExitButton;
        private System.Windows.Forms.DataGridView MainAppointmentDGV;
        private System.Windows.Forms.Button MainAddAppointmentButton;
        private System.Windows.Forms.Button MainEditAppointmentButton;
        private System.Windows.Forms.Button MainDeleteAppointmentButton;
        private System.Windows.Forms.Label MainAppointmentsLabel;
        private System.Windows.Forms.MonthCalendar MainAppointmentMontCalendar;
        private System.Windows.Forms.Button MainMonthCalendarResetButton;
    }
}