namespace DBapplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginAsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginAsComboBox
            // 
            this.loginAsComboBox.FormattingEnabled = true;
            this.loginAsComboBox.Location = new System.Drawing.Point(457, 118);
            this.loginAsComboBox.Name = "loginAsComboBox";
            this.loginAsComboBox.Size = new System.Drawing.Size(132, 24);
            this.loginAsComboBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(352, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Login As:";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WelcomeLabel.Location = new System.Drawing.Point(327, 8);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(292, 25);
            this.WelcomeLabel.TabIndex = 15;
            this.WelcomeLabel.Text = "Welcome to Our Hospital DBMS";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(457, 51);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_username.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(352, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoEllipsis = true;
            this.Btn_Login.Location = new System.Drawing.Point(355, 165);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(101, 28);
            this.Btn_Login.TabIndex = 12;
            this.Btn_Login.Text = "&Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click_1);
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(457, 83);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_pass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(352, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(692, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginAsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loginAsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}