namespace C969.Forms
{
    partial class AppointmentTypesByMonth
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
            this.AppointmentTypesByMonthDGV = new System.Windows.Forms.DataGridView();
            this.AppointmentTypesByMonthLabel = new System.Windows.Forms.Label();
            this.AppointmentTypesByMonthCloseReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesByMonthDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentTypesByMonthDGV
            // 
            this.AppointmentTypesByMonthDGV.AllowUserToAddRows = false;
            this.AppointmentTypesByMonthDGV.AllowUserToDeleteRows = false;
            this.AppointmentTypesByMonthDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentTypesByMonthDGV.Location = new System.Drawing.Point(72, 71);
            this.AppointmentTypesByMonthDGV.MultiSelect = false;
            this.AppointmentTypesByMonthDGV.Name = "AppointmentTypesByMonthDGV";
            this.AppointmentTypesByMonthDGV.ReadOnly = true;
            this.AppointmentTypesByMonthDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentTypesByMonthDGV.ShowEditingIcon = false;
            this.AppointmentTypesByMonthDGV.Size = new System.Drawing.Size(654, 297);
            this.AppointmentTypesByMonthDGV.TabIndex = 0;
            this.AppointmentTypesByMonthDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MyDataBindingComplete);
            // 
            // AppointmentTypesByMonthLabel
            // 
            this.AppointmentTypesByMonthLabel.AutoSize = true;
            this.AppointmentTypesByMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTypesByMonthLabel.Location = new System.Drawing.Point(266, 27);
            this.AppointmentTypesByMonthLabel.Name = "AppointmentTypesByMonthLabel";
            this.AppointmentTypesByMonthLabel.Size = new System.Drawing.Size(270, 20);
            this.AppointmentTypesByMonthLabel.TabIndex = 1;
            this.AppointmentTypesByMonthLabel.Text = "Appointment Types By Month Report";
            // 
            // AppointmentTypesByMonthCloseReportButton
            // 
            this.AppointmentTypesByMonthCloseReportButton.Location = new System.Drawing.Point(713, 415);
            this.AppointmentTypesByMonthCloseReportButton.Name = "AppointmentTypesByMonthCloseReportButton";
            this.AppointmentTypesByMonthCloseReportButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentTypesByMonthCloseReportButton.TabIndex = 2;
            this.AppointmentTypesByMonthCloseReportButton.Text = "Close";
            this.AppointmentTypesByMonthCloseReportButton.UseVisualStyleBackColor = true;
            this.AppointmentTypesByMonthCloseReportButton.Click += new System.EventHandler(this.AppointmentTypesByMonthCloseReportButton_Click);
            // 
            // AppointmentTypesByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppointmentTypesByMonthCloseReportButton);
            this.Controls.Add(this.AppointmentTypesByMonthLabel);
            this.Controls.Add(this.AppointmentTypesByMonthDGV);
            this.Name = "AppointmentTypesByMonth";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesByMonthDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentTypesByMonthDGV;
        private System.Windows.Forms.Label AppointmentTypesByMonthLabel;
        private System.Windows.Forms.Button AppointmentTypesByMonthCloseReportButton;
    }
}