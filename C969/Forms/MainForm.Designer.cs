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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainAddCustomerButton = new System.Windows.Forms.Button();
            this.MainEditCustomerButton = new System.Windows.Forms.Button();
            this.MainDeleteCustomerButton = new System.Windows.Forms.Button();
            this.MainCustomersLabel = new System.Windows.Forms.Label();
            this.MainExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainAddCustomerButton
            // 
            this.MainAddCustomerButton.Location = new System.Drawing.Point(389, 10);
            this.MainAddCustomerButton.Name = "MainAddCustomerButton";
            this.MainAddCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainAddCustomerButton.TabIndex = 1;
            this.MainAddCustomerButton.Text = "Add";
            this.MainAddCustomerButton.UseVisualStyleBackColor = true;
            this.MainAddCustomerButton.Click += new System.EventHandler(this.MainAddCustomerButton_Click);
            // 
            // MainEditCustomerButton
            // 
            this.MainEditCustomerButton.Location = new System.Drawing.Point(470, 10);
            this.MainEditCustomerButton.Name = "MainEditCustomerButton";
            this.MainEditCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainEditCustomerButton.TabIndex = 2;
            this.MainEditCustomerButton.Text = "Edit";
            this.MainEditCustomerButton.UseVisualStyleBackColor = true;
            // 
            // MainDeleteCustomerButton
            // 
            this.MainDeleteCustomerButton.Location = new System.Drawing.Point(551, 10);
            this.MainDeleteCustomerButton.Name = "MainDeleteCustomerButton";
            this.MainDeleteCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.MainDeleteCustomerButton.TabIndex = 3;
            this.MainDeleteCustomerButton.Text = "Delete";
            this.MainDeleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // MainCustomersLabel
            // 
            this.MainCustomersLabel.AutoSize = true;
            this.MainCustomersLabel.Location = new System.Drawing.Point(127, 15);
            this.MainCustomersLabel.Name = "MainCustomersLabel";
            this.MainCustomersLabel.Size = new System.Drawing.Size(56, 13);
            this.MainCustomersLabel.TabIndex = 4;
            this.MainCustomersLabel.Text = "Customers";
            // 
            // MainExitButton
            // 
            this.MainExitButton.Location = new System.Drawing.Point(713, 415);
            this.MainExitButton.Name = "MainExitButton";
            this.MainExitButton.Size = new System.Drawing.Size(75, 23);
            this.MainExitButton.TabIndex = 5;
            this.MainExitButton.Text = "Exit";
            this.MainExitButton.UseVisualStyleBackColor = true;
            this.MainExitButton.Click += new System.EventHandler(this.MainExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainExitButton);
            this.Controls.Add(this.MainCustomersLabel);
            this.Controls.Add(this.MainDeleteCustomerButton);
            this.Controls.Add(this.MainEditCustomerButton);
            this.Controls.Add(this.MainAddCustomerButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MainAddCustomerButton;
        private System.Windows.Forms.Button MainEditCustomerButton;
        private System.Windows.Forms.Button MainDeleteCustomerButton;
        private System.Windows.Forms.Label MainCustomersLabel;
        private System.Windows.Forms.Button MainExitButton;
    }
}