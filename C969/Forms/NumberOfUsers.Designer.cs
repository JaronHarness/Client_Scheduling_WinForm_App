namespace C969.Forms
{
    partial class NumberOfUsers
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
            this.NumberOfUsersTitleLabel = new System.Windows.Forms.Label();
            this.NumberOfUsersDGV = new System.Windows.Forms.DataGridView();
            this.NumberOfUsersCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfUsersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfUsersTitleLabel
            // 
            this.NumberOfUsersTitleLabel.AutoSize = true;
            this.NumberOfUsersTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfUsersTitleLabel.Location = new System.Drawing.Point(99, 23);
            this.NumberOfUsersTitleLabel.Name = "NumberOfUsersTitleLabel";
            this.NumberOfUsersTitleLabel.Size = new System.Drawing.Size(129, 20);
            this.NumberOfUsersTitleLabel.TabIndex = 0;
            this.NumberOfUsersTitleLabel.Text = "Number of Users";
            // 
            // NumberOfUsersDGV
            // 
            this.NumberOfUsersDGV.AllowUserToAddRows = false;
            this.NumberOfUsersDGV.AllowUserToDeleteRows = false;
            this.NumberOfUsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NumberOfUsersDGV.Location = new System.Drawing.Point(37, 59);
            this.NumberOfUsersDGV.MultiSelect = false;
            this.NumberOfUsersDGV.Name = "NumberOfUsersDGV";
            this.NumberOfUsersDGV.ReadOnly = true;
            this.NumberOfUsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NumberOfUsersDGV.Size = new System.Drawing.Size(252, 193);
            this.NumberOfUsersDGV.TabIndex = 1;
            this.NumberOfUsersDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myDataBindingComplete);
            // 
            // NumberOfUsersCloseButton
            // 
            this.NumberOfUsersCloseButton.Location = new System.Drawing.Point(214, 271);
            this.NumberOfUsersCloseButton.Name = "NumberOfUsersCloseButton";
            this.NumberOfUsersCloseButton.Size = new System.Drawing.Size(75, 23);
            this.NumberOfUsersCloseButton.TabIndex = 2;
            this.NumberOfUsersCloseButton.Text = "Close";
            this.NumberOfUsersCloseButton.UseVisualStyleBackColor = true;
            this.NumberOfUsersCloseButton.Click += new System.EventHandler(this.NumberOfUsersCloseButton_Click);
            // 
            // NumberOfUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 324);
            this.Controls.Add(this.NumberOfUsersCloseButton);
            this.Controls.Add(this.NumberOfUsersDGV);
            this.Controls.Add(this.NumberOfUsersTitleLabel);
            this.Name = "NumberOfUsers";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfUsersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfUsersTitleLabel;
        private System.Windows.Forms.DataGridView NumberOfUsersDGV;
        private System.Windows.Forms.Button NumberOfUsersCloseButton;
    }
}