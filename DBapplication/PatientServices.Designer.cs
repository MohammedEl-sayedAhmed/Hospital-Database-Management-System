namespace DBapplication
{
    partial class PatientServices
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
            this.view_bills_button = new System.Windows.Forms.Button();
            this.view_history_button = new System.Windows.Forms.Button();
            this.change_room_button = new System.Windows.Forms.Button();
            this.update_info_button = new System.Windows.Forms.Button();
            this.rate_doctor_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // view_bills_button
            // 
            this.view_bills_button.Location = new System.Drawing.Point(85, 78);
            this.view_bills_button.Name = "view_bills_button";
            this.view_bills_button.Size = new System.Drawing.Size(128, 27);
            this.view_bills_button.TabIndex = 1;
            this.view_bills_button.Text = "View Bills";
            this.view_bills_button.UseVisualStyleBackColor = true;
            this.view_bills_button.Click += new System.EventHandler(this.view_bills_button_Click);
            // 
            // view_history_button
            // 
            this.view_history_button.Location = new System.Drawing.Point(85, 111);
            this.view_history_button.Name = "view_history_button";
            this.view_history_button.Size = new System.Drawing.Size(128, 27);
            this.view_history_button.TabIndex = 2;
            this.view_history_button.Text = "View History";
            this.view_history_button.UseVisualStyleBackColor = true;
            this.view_history_button.Click += new System.EventHandler(this.view_history_button_Click);
            // 
            // change_room_button
            // 
            this.change_room_button.Location = new System.Drawing.Point(85, 161);
            this.change_room_button.Name = "change_room_button";
            this.change_room_button.Size = new System.Drawing.Size(128, 27);
            this.change_room_button.TabIndex = 3;
            this.change_room_button.Text = "Change Room";
            this.change_room_button.UseVisualStyleBackColor = true;
            this.change_room_button.Click += new System.EventHandler(this.change_room_button_Click);
            // 
            // update_info_button
            // 
            this.update_info_button.Location = new System.Drawing.Point(85, 244);
            this.update_info_button.Name = "update_info_button";
            this.update_info_button.Size = new System.Drawing.Size(128, 27);
            this.update_info_button.TabIndex = 4;
            this.update_info_button.Text = "Update Info";
            this.update_info_button.UseVisualStyleBackColor = true;
            this.update_info_button.Click += new System.EventHandler(this.update_info_button_Click);
            // 
            // rate_doctor_button
            // 
            this.rate_doctor_button.Location = new System.Drawing.Point(85, 194);
            this.rate_doctor_button.Name = "rate_doctor_button";
            this.rate_doctor_button.Size = new System.Drawing.Size(128, 27);
            this.rate_doctor_button.TabIndex = 5;
            this.rate_doctor_button.Text = "Rate Doctor";
            this.rate_doctor_button.UseVisualStyleBackColor = true;
            this.rate_doctor_button.Click += new System.EventHandler(this.rate_doctor_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(106, 309);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(87, 27);
            this.logout_button.TabIndex = 7;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Available Services";
            // 
            // PatientServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.rate_doctor_button);
            this.Controls.Add(this.update_info_button);
            this.Controls.Add(this.change_room_button);
            this.Controls.Add(this.view_history_button);
            this.Controls.Add(this.view_bills_button);
            this.Name = "PatientServices";
            this.Text = "PatientServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button view_bills_button;
        private System.Windows.Forms.Button view_history_button;
        private System.Windows.Forms.Button change_room_button;
        private System.Windows.Forms.Button update_info_button;
        private System.Windows.Forms.Button rate_doctor_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
    }
}