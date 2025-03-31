namespace C969.Forms
{
    partial class ScheduleByUser
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
            this.ScheduleByUserTitleLabel = new System.Windows.Forms.Label();
            this.ScheduleByUserDGV = new System.Windows.Forms.DataGridView();
            this.SchedultByUserCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleByUserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleByUserTitleLabel
            // 
            this.ScheduleByUserTitleLabel.AutoSize = true;
            this.ScheduleByUserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleByUserTitleLabel.Location = new System.Drawing.Point(331, 30);
            this.ScheduleByUserTitleLabel.Name = "ScheduleByUserTitleLabel";
            this.ScheduleByUserTitleLabel.Size = new System.Drawing.Size(136, 20);
            this.ScheduleByUserTitleLabel.TabIndex = 0;
            this.ScheduleByUserTitleLabel.Text = "Schedule By User";
            // 
            // ScheduleByUserDGV
            // 
            this.ScheduleByUserDGV.AllowUserToAddRows = false;
            this.ScheduleByUserDGV.AllowUserToDeleteRows = false;
            this.ScheduleByUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleByUserDGV.Location = new System.Drawing.Point(49, 67);
            this.ScheduleByUserDGV.MultiSelect = false;
            this.ScheduleByUserDGV.Name = "ScheduleByUserDGV";
            this.ScheduleByUserDGV.ReadOnly = true;
            this.ScheduleByUserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleByUserDGV.Size = new System.Drawing.Size(702, 322);
            this.ScheduleByUserDGV.TabIndex = 1;
            this.ScheduleByUserDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myDataBindingComplete);
            // 
            // SchedultByUserCloseButton
            // 
            this.SchedultByUserCloseButton.Location = new System.Drawing.Point(676, 404);
            this.SchedultByUserCloseButton.Name = "SchedultByUserCloseButton";
            this.SchedultByUserCloseButton.Size = new System.Drawing.Size(75, 23);
            this.SchedultByUserCloseButton.TabIndex = 2;
            this.SchedultByUserCloseButton.Text = "Close";
            this.SchedultByUserCloseButton.UseVisualStyleBackColor = true;
            this.SchedultByUserCloseButton.Click += new System.EventHandler(this.SchedultByUserCloseButton_Click);
            // 
            // ScheduleByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SchedultByUserCloseButton);
            this.Controls.Add(this.ScheduleByUserDGV);
            this.Controls.Add(this.ScheduleByUserTitleLabel);
            this.Name = "ScheduleByUser";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleByUserDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleByUserTitleLabel;
        private System.Windows.Forms.DataGridView ScheduleByUserDGV;
        private System.Windows.Forms.Button SchedultByUserCloseButton;
    }
}