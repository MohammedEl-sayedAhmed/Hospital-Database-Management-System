namespace DBapplication
{
    partial class D_UpdatePatientState
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
            this.label2 = new System.Windows.Forms.Label();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.uod_state_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "State:";
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(128, 42);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(158, 21);
            this.PatientComboBox.TabIndex = 2;
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(128, 86);
            this.StateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(158, 21);
            this.StateComboBox.TabIndex = 3;
            // 
            // uod_state_button
            // 
            this.uod_state_button.Location = new System.Drawing.Point(112, 142);
            this.uod_state_button.Margin = new System.Windows.Forms.Padding(2);
            this.uod_state_button.Name = "uod_state_button";
            this.uod_state_button.Size = new System.Drawing.Size(104, 20);
            this.uod_state_button.TabIndex = 4;
            this.uod_state_button.Text = "Update State";
            this.uod_state_button.UseVisualStyleBackColor = true;
            this.uod_state_button.Click += new System.EventHandler(this.uod_state_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(166, 206);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 27;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(82, 206);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 26;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // D_UpdatePatientState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 259);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.uod_state_button);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "D_UpdatePatientState";
            this.Text = "D_UpdatePatientState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Button uod_state_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
    }
}