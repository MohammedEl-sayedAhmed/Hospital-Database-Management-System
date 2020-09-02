namespace DBapplication
{
    partial class A_AddUpdateScan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScansComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateScanButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.choose_scan_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(109, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(109, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // ScansComboBox
            // 
            this.ScansComboBox.FormattingEnabled = true;
            this.ScansComboBox.Location = new System.Drawing.Point(252, 34);
            this.ScansComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScansComboBox.Name = "ScansComboBox";
            this.ScansComboBox.Size = new System.Drawing.Size(160, 24);
            this.ScansComboBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(192, 121);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(192, 185);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.PriceTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(66, 270);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 28);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Scan";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateScanButton
            // 
            this.UpdateScanButton.Location = new System.Drawing.Point(234, 270);
            this.UpdateScanButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateScanButton.Name = "UpdateScanButton";
            this.UpdateScanButton.Size = new System.Drawing.Size(123, 28);
            this.UpdateScanButton.TabIndex = 9;
            this.UpdateScanButton.Text = "Update Scan";
            this.UpdateScanButton.UseVisualStyleBackColor = true;
            this.UpdateScanButton.Click += new System.EventHandler(this.UpdateScanButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(66, 312);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(123, 28);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(234, 312);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(123, 28);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // choose_scan_button
            // 
            this.choose_scan_button.Location = new System.Drawing.Point(25, 32);
            this.choose_scan_button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_scan_button.Name = "choose_scan_button";
            this.choose_scan_button.Size = new System.Drawing.Size(207, 28);
            this.choose_scan_button.TabIndex = 12;
            this.choose_scan_button.Text = "Choose A Scan To Update:";
            this.choose_scan_button.UseVisualStyleBackColor = true;
            this.choose_scan_button.Click += new System.EventHandler(this.choose_scan_button_Click);
            // 
            // A_AddUpdateScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 373);
            this.Controls.Add(this.choose_scan_button);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateScanButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ScansComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_AddUpdateScan";
            this.Text = "A_AddUpdateScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ScansComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateScanButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button choose_scan_button;
    }
}