namespace DBapplication
{
    partial class A_UpdateInfo
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.upd_info_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(159, 109);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 22);
            this.usernameTextBox.TabIndex = 49;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(236, 309);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 48;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(125, 309);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 47;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // upd_info_button
            // 
            this.upd_info_button.Location = new System.Drawing.Point(164, 230);
            this.upd_info_button.Name = "upd_info_button";
            this.upd_info_button.Size = new System.Drawing.Size(139, 25);
            this.upd_info_button.TabIndex = 46;
            this.upd_info_button.Text = "Update Info";
            this.upd_info_button.UseVisualStyleBackColor = true;
            this.upd_info_button.Click += new System.EventHandler(this.upd_info_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(159, 160);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 22);
            this.passwordTextBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 22);
            this.nameTextBox.TabIndex = 52;
            // 
            // A_UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 397);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.upd_info_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A_UpdateInfo";
            this.Text = "A_UpdateInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button upd_info_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}