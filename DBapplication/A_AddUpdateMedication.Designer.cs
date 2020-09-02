namespace DBapplication
{
    partial class A_AddUpdateMedication
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
            this.label5 = new System.Windows.Forms.Label();
            this.MedicationsComboBox = new System.Windows.Forms.ComboBox();
            this.MedicationNameBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ExpiaryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddMedicationButton = new System.Windows.Forms.Button();
            this.UpdateMedicationButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.choose_med_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiary Date: ";
            // 
            // MedicationsComboBox
            // 
            this.MedicationsComboBox.FormattingEnabled = true;
            this.MedicationsComboBox.Location = new System.Drawing.Point(294, 32);
            this.MedicationsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicationsComboBox.Name = "MedicationsComboBox";
            this.MedicationsComboBox.Size = new System.Drawing.Size(160, 24);
            this.MedicationsComboBox.TabIndex = 5;
            // 
            // MedicationNameBox
            // 
            this.MedicationNameBox.Location = new System.Drawing.Point(189, 137);
            this.MedicationNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicationNameBox.Name = "MedicationNameBox";
            this.MedicationNameBox.Size = new System.Drawing.Size(263, 22);
            this.MedicationNameBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(189, 184);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(263, 22);
            this.PriceTextBox.TabIndex = 8;
            // 
            // ExpiaryDateTimePicker
            // 
            this.ExpiaryDateTimePicker.Location = new System.Drawing.Point(189, 230);
            this.ExpiaryDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ExpiaryDateTimePicker.Name = "ExpiaryDateTimePicker";
            this.ExpiaryDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.ExpiaryDateTimePicker.TabIndex = 9;
            // 
            // AddMedicationButton
            // 
            this.AddMedicationButton.Location = new System.Drawing.Point(48, 334);
            this.AddMedicationButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMedicationButton.Name = "AddMedicationButton";
            this.AddMedicationButton.Size = new System.Drawing.Size(149, 28);
            this.AddMedicationButton.TabIndex = 10;
            this.AddMedicationButton.Text = "Add Medication";
            this.AddMedicationButton.UseVisualStyleBackColor = true;
            this.AddMedicationButton.Click += new System.EventHandler(this.AddMedicationButton_Click);
            // 
            // UpdateMedicationButton
            // 
            this.UpdateMedicationButton.Location = new System.Drawing.Point(305, 334);
            this.UpdateMedicationButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateMedicationButton.Name = "UpdateMedicationButton";
            this.UpdateMedicationButton.Size = new System.Drawing.Size(149, 28);
            this.UpdateMedicationButton.TabIndex = 11;
            this.UpdateMedicationButton.Text = "Update Medication";
            this.UpdateMedicationButton.UseVisualStyleBackColor = true;
            this.UpdateMedicationButton.Click += new System.EventHandler(this.UpdateMedicationButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(48, 382);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(149, 28);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(305, 382);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(149, 28);
            this.LogOutButton.TabIndex = 13;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // choose_med_button
            // 
            this.choose_med_button.Location = new System.Drawing.Point(55, 30);
            this.choose_med_button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_med_button.Name = "choose_med_button";
            this.choose_med_button.Size = new System.Drawing.Size(224, 28);
            this.choose_med_button.TabIndex = 15;
            this.choose_med_button.Text = "Select A Medication to Update:";
            this.choose_med_button.UseVisualStyleBackColor = true;
            this.choose_med_button.Click += new System.EventHandler(this.choose_med_button_Click);
            // 
            // A_AddUpdateMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 443);
            this.Controls.Add(this.choose_med_button);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateMedicationButton);
            this.Controls.Add(this.AddMedicationButton);
            this.Controls.Add(this.ExpiaryDateTimePicker);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.MedicationNameBox);
            this.Controls.Add(this.MedicationsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_AddUpdateMedication";
            this.Text = "A_AddUpdateMedication";
            this.Load += new System.EventHandler(this.A_AddUpdateMedication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MedicationsComboBox;
        private System.Windows.Forms.TextBox MedicationNameBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.DateTimePicker ExpiaryDateTimePicker;
        private System.Windows.Forms.Button AddMedicationButton;
        private System.Windows.Forms.Button UpdateMedicationButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button choose_med_button;
    }
}