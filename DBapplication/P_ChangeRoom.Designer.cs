namespace DBapplication
{
    partial class P_ChangeRoom
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
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.ChnageRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.curr_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(281, 292);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 95;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(170, 292);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 94;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ChnageRoom
            // 
            this.ChnageRoom.Location = new System.Drawing.Point(203, 183);
            this.ChnageRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChnageRoom.Name = "ChnageRoom";
            this.ChnageRoom.Size = new System.Drawing.Size(149, 27);
            this.ChnageRoom.TabIndex = 96;
            this.ChnageRoom.Text = "Change Room";
            this.ChnageRoom.UseVisualStyleBackColor = true;
            this.ChnageRoom.Click += new System.EventHandler(this.ChnageRoom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(76, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Current room type is :";
            // 
            // curr_type
            // 
            this.curr_type.AutoSize = true;
            this.curr_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.curr_type.Location = new System.Drawing.Point(277, 52);
            this.curr_type.Name = "curr_type";
            this.curr_type.Size = new System.Drawing.Size(40, 20);
            this.curr_type.TabIndex = 98;
            this.curr_type.Text = "type";
            this.curr_type.Click += new System.EventHandler(this.label1_Click);
            // 
            // P_ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 367);
            this.Controls.Add(this.curr_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChnageRoom);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "P_ChangeRoom";
            this.Text = "P_ChangeRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button ChnageRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label curr_type;
    }
}