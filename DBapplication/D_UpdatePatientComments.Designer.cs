namespace DBapplication
{
    partial class D_UpdatePatientComments
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
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.upd_comm_button = new System.Windows.Forms.Button();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(112, 92);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(188, 20);
            this.commentsTextBox.TabIndex = 42;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(174, 212);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 41;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(91, 212);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 40;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // upd_comm_button
            // 
            this.upd_comm_button.Location = new System.Drawing.Point(120, 148);
            this.upd_comm_button.Margin = new System.Windows.Forms.Padding(2);
            this.upd_comm_button.Name = "upd_comm_button";
            this.upd_comm_button.Size = new System.Drawing.Size(104, 20);
            this.upd_comm_button.TabIndex = 39;
            this.upd_comm_button.Text = "Update Comments";
            this.upd_comm_button.UseVisualStyleBackColor = true;
            this.upd_comm_button.Click += new System.EventHandler(this.upd_comm_button_Click);
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(112, 46);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(188, 21);
            this.PatientComboBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Comments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Patient:";
            // 
            // D_UpdatePatientComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 280);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.upd_comm_button);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "D_UpdatePatientComments";
            this.Text = "D_UpdatePatientComments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button upd_comm_button;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}