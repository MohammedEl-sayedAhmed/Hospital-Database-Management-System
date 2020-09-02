namespace DBapplication
{
    partial class A_ViewPatientRegistrations
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
            this.patientRegistrationGridView = new System.Windows.Forms.DataGridView();
            this.PatientRegistrationCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_registration_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegistrationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientRegistrationGridView
            // 
            this.patientRegistrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRegistrationGridView.Location = new System.Drawing.Point(48, 65);
            this.patientRegistrationGridView.Margin = new System.Windows.Forms.Padding(4);
            this.patientRegistrationGridView.Name = "patientRegistrationGridView";
            this.patientRegistrationGridView.RowHeadersWidth = 51;
            this.patientRegistrationGridView.Size = new System.Drawing.Size(359, 185);
            this.patientRegistrationGridView.TabIndex = 108;
            // 
            // PatientRegistrationCombobox
            // 
            this.PatientRegistrationCombobox.FormattingEnabled = true;
            this.PatientRegistrationCombobox.Location = new System.Drawing.Point(190, 18);
            this.PatientRegistrationCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientRegistrationCombobox.Name = "PatientRegistrationCombobox";
            this.PatientRegistrationCombobox.Size = new System.Drawing.Size(209, 24);
            this.PatientRegistrationCombobox.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Patient Name:";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(228, 326);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 105;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(117, 326);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 104;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_registration_btn
            // 
            this.view_registration_btn.Location = new System.Drawing.Point(117, 272);
            this.view_registration_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_registration_btn.Name = "view_registration_btn";
            this.view_registration_btn.Size = new System.Drawing.Size(216, 33);
            this.view_registration_btn.TabIndex = 103;
            this.view_registration_btn.Text = "View Regestrations";
            this.view_registration_btn.UseVisualStyleBackColor = true;
            this.view_registration_btn.Click += new System.EventHandler(this.view_registration_btn_Click);
            // 
            // A_ViewPatientRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 373);
            this.Controls.Add(this.patientRegistrationGridView);
            this.Controls.Add(this.PatientRegistrationCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_registration_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_ViewPatientRegistrations";
            this.Text = "A_ViewPatientRegistrations";
            this.Load += new System.EventHandler(this.A_ViewPatientRegistrations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientRegistrationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientRegistrationGridView;
        private System.Windows.Forms.ComboBox PatientRegistrationCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_registration_btn;
    }
}