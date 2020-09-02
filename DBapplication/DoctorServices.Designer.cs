namespace DBapplication
{
    partial class DoctorServices
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
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.pat_diag_button = new System.Windows.Forms.Button();
            this.update_info_button = new System.Windows.Forms.Button();
            this.assign_med_button = new System.Windows.Forms.Button();
            this.pat_comments_button = new System.Windows.Forms.Button();
            this.req_scan_button = new System.Windows.Forms.Button();
            this.pat_state_button = new System.Windows.Forms.Button();
            this.view_sched_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available Services";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(107, 385);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 15;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // pat_diag_button
            // 
            this.pat_diag_button.Location = new System.Drawing.Point(68, 209);
            this.pat_diag_button.Name = "pat_diag_button";
            this.pat_diag_button.Size = new System.Drawing.Size(184, 27);
            this.pat_diag_button.TabIndex = 13;
            this.pat_diag_button.Text = "Update Patient Diagnosis";
            this.pat_diag_button.UseVisualStyleBackColor = true;
            this.pat_diag_button.Click += new System.EventHandler(this.pat_diag_button_Click);
            // 
            // update_info_button
            // 
            this.update_info_button.Location = new System.Drawing.Point(68, 325);
            this.update_info_button.Name = "update_info_button";
            this.update_info_button.Size = new System.Drawing.Size(184, 27);
            this.update_info_button.TabIndex = 12;
            this.update_info_button.Text = "Update Info";
            this.update_info_button.UseVisualStyleBackColor = true;
            this.update_info_button.Click += new System.EventHandler(this.update_info_button_Click);
            // 
            // assign_med_button
            // 
            this.assign_med_button.Location = new System.Drawing.Point(68, 93);
            this.assign_med_button.Name = "assign_med_button";
            this.assign_med_button.Size = new System.Drawing.Size(184, 27);
            this.assign_med_button.TabIndex = 11;
            this.assign_med_button.Text = "Assign Medication";
            this.assign_med_button.UseVisualStyleBackColor = true;
            this.assign_med_button.Click += new System.EventHandler(this.assign_med_button_Click);
            // 
            // pat_comments_button
            // 
            this.pat_comments_button.Location = new System.Drawing.Point(68, 242);
            this.pat_comments_button.Name = "pat_comments_button";
            this.pat_comments_button.Size = new System.Drawing.Size(184, 27);
            this.pat_comments_button.TabIndex = 10;
            this.pat_comments_button.Text = "Update Patient Comments";
            this.pat_comments_button.UseVisualStyleBackColor = true;
            this.pat_comments_button.Click += new System.EventHandler(this.pat_comments_button_Click);
            // 
            // req_scan_button
            // 
            this.req_scan_button.Location = new System.Drawing.Point(68, 126);
            this.req_scan_button.Name = "req_scan_button";
            this.req_scan_button.Size = new System.Drawing.Size(184, 27);
            this.req_scan_button.TabIndex = 9;
            this.req_scan_button.Text = "Request Scan";
            this.req_scan_button.UseVisualStyleBackColor = true;
            this.req_scan_button.Click += new System.EventHandler(this.req_scan_button_Click);
            // 
            // pat_state_button
            // 
            this.pat_state_button.Location = new System.Drawing.Point(68, 176);
            this.pat_state_button.Name = "pat_state_button";
            this.pat_state_button.Size = new System.Drawing.Size(184, 27);
            this.pat_state_button.TabIndex = 17;
            this.pat_state_button.Text = "Update Patient State";
            this.pat_state_button.UseVisualStyleBackColor = true;
            this.pat_state_button.Click += new System.EventHandler(this.pat_state_button_Click);
            // 
            // view_sched_button
            // 
            this.view_sched_button.Location = new System.Drawing.Point(68, 292);
            this.view_sched_button.Name = "view_sched_button";
            this.view_sched_button.Size = new System.Drawing.Size(184, 27);
            this.view_sched_button.TabIndex = 18;
            this.view_sched_button.Text = "View Schedule";
            this.view_sched_button.UseVisualStyleBackColor = true;
            this.view_sched_button.Click += new System.EventHandler(this.view_sched_button_Click);
            // 
            // DoctorServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.view_sched_button);
            this.Controls.Add(this.pat_state_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.pat_diag_button);
            this.Controls.Add(this.update_info_button);
            this.Controls.Add(this.assign_med_button);
            this.Controls.Add(this.pat_comments_button);
            this.Controls.Add(this.req_scan_button);
            this.Name = "DoctorServices";
            this.Text = "DoctorServices";
            this.Load += new System.EventHandler(this.DoctorServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button pat_diag_button;
        private System.Windows.Forms.Button update_info_button;
        private System.Windows.Forms.Button assign_med_button;
        private System.Windows.Forms.Button pat_comments_button;
        private System.Windows.Forms.Button req_scan_button;
        private System.Windows.Forms.Button pat_state_button;
        private System.Windows.Forms.Button view_sched_button;
    }
}