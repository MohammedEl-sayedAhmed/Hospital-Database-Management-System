namespace DBapplication
{
    partial class R_RegisterPatient
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
            this.back_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReservedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RegisterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(89, 375);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(125, 34);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(379, 375);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(125, 34);
            this.logout_button.TabIndex = 1;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doctor Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Type :";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(314, 81);
            this.DoctorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(160, 24);
            this.DoctorComboBox.TabIndex = 7;
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(314, 133);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(160, 24);
            this.PatientComboBox.TabIndex = 8;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(314, 183);
            this.RoomComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(160, 24);
            this.RoomComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reserved Time Slot";
            // 
            // ReservedNumericUpDown
            // 
            this.ReservedNumericUpDown.Location = new System.Drawing.Point(314, 238);
            this.ReservedNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReservedNumericUpDown.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.ReservedNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ReservedNumericUpDown.Name = "ReservedNumericUpDown";
            this.ReservedNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.ReservedNumericUpDown.TabIndex = 11;
            this.ReservedNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(236, 325);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(125, 38);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register Patient";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // R_RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ReservedNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "R_RegisterPatient";
            this.Text = "R_RegisterPatient";
            ((System.ComponentModel.ISupportInitialize)(this.ReservedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ReservedNumericUpDown;
        private System.Windows.Forms.Button RegisterButton;
    }
}