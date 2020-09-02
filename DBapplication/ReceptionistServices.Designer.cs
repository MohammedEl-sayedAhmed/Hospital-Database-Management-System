namespace DBapplication
{
    partial class ReceptionistServices
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
            this.personnel_search_button = new System.Windows.Forms.Button();
            this.update_info_button = new System.Windows.Forms.Button();
            this.register_pat_button = new System.Windows.Forms.Button();
            this.add_upd_pat_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available Services";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(97, 253);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(102, 27);
            this.logout_button.TabIndex = 15;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // personnel_search_button
            // 
            this.personnel_search_button.Location = new System.Drawing.Point(76, 161);
            this.personnel_search_button.Name = "personnel_search_button";
            this.personnel_search_button.Size = new System.Drawing.Size(150, 27);
            this.personnel_search_button.TabIndex = 13;
            this.personnel_search_button.Text = "Personnel Search";
            this.personnel_search_button.UseVisualStyleBackColor = true;
            this.personnel_search_button.Click += new System.EventHandler(this.personnel_search_button_Click);
            // 
            // update_info_button
            // 
            this.update_info_button.Location = new System.Drawing.Point(76, 194);
            this.update_info_button.Name = "update_info_button";
            this.update_info_button.Size = new System.Drawing.Size(150, 27);
            this.update_info_button.TabIndex = 12;
            this.update_info_button.Text = "Update Info";
            this.update_info_button.UseVisualStyleBackColor = true;
            this.update_info_button.Click += new System.EventHandler(this.update_info_button_Click);
            // 
            // register_pat_button
            // 
            this.register_pat_button.Location = new System.Drawing.Point(76, 111);
            this.register_pat_button.Name = "register_pat_button";
            this.register_pat_button.Size = new System.Drawing.Size(150, 27);
            this.register_pat_button.TabIndex = 10;
            this.register_pat_button.Text = "Register Patient";
            this.register_pat_button.UseVisualStyleBackColor = true;
            this.register_pat_button.Click += new System.EventHandler(this.register_pat_button_Click);
            // 
            // add_upd_pat_button
            // 
            this.add_upd_pat_button.Location = new System.Drawing.Point(76, 78);
            this.add_upd_pat_button.Name = "add_upd_pat_button";
            this.add_upd_pat_button.Size = new System.Drawing.Size(150, 27);
            this.add_upd_pat_button.TabIndex = 9;
            this.add_upd_pat_button.Text = "Add/Update Patient";
            this.add_upd_pat_button.UseVisualStyleBackColor = true;
            this.add_upd_pat_button.Click += new System.EventHandler(this.add_upd_pat_button_Click);
            // 
            // ReceptionistServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.personnel_search_button);
            this.Controls.Add(this.update_info_button);
            this.Controls.Add(this.register_pat_button);
            this.Controls.Add(this.add_upd_pat_button);
            this.Name = "ReceptionistServices";
            this.Text = "ReceptionistServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button personnel_search_button;
        private System.Windows.Forms.Button update_info_button;
        private System.Windows.Forms.Button register_pat_button;
        private System.Windows.Forms.Button add_upd_pat_button;
    }
}