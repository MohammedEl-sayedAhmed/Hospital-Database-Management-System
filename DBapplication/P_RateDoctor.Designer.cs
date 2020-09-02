namespace DBapplication
{
    partial class P_RateDoctor
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
            this.rate_doctor_btn = new System.Windows.Forms.Button();
            this.last_visited_doc_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_button.Location = new System.Drawing.Point(233, 255);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 30;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.Location = new System.Drawing.Point(121, 255);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 29;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // rate_doctor_btn
            // 
            this.rate_doctor_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rate_doctor_btn.Location = new System.Drawing.Point(157, 214);
            this.rate_doctor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rate_doctor_btn.Name = "rate_doctor_btn";
            this.rate_doctor_btn.Size = new System.Drawing.Size(139, 25);
            this.rate_doctor_btn.TabIndex = 28;
            this.rate_doctor_btn.Text = "Rate Doctor";
            this.rate_doctor_btn.UseVisualStyleBackColor = true;
            this.rate_doctor_btn.Click += new System.EventHandler(this.rate_doctor_btn_Click);
            // 
            // last_visited_doc_name
            // 
            this.last_visited_doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_visited_doc_name.Location = new System.Drawing.Point(243, 62);
            this.last_visited_doc_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_visited_doc_name.Name = "last_visited_doc_name";
            this.last_visited_doc_name.Size = new System.Drawing.Size(220, 33);
            this.last_visited_doc_name.TabIndex = 32;
            this.last_visited_doc_name.Text = "text from queury";
            this.last_visited_doc_name.Click += new System.EventHandler(this.last_visited_doc_name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last visited doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(59, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rate (from 0 to 10):";
            // 
            // RateNumericUpDown
            // 
            this.RateNumericUpDown.Location = new System.Drawing.Point(255, 109);
            this.RateNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RateNumericUpDown.Name = "RateNumericUpDown";
            this.RateNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.RateNumericUpDown.TabIndex = 36;
            // 
            // P_RateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 310);
            this.Controls.Add(this.RateNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.last_visited_doc_name);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.rate_doctor_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "P_RateDoctor";
            this.Text = "P_RateDoctor";
            this.Load += new System.EventHandler(this.P_RateDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button rate_doctor_btn;
        private System.Windows.Forms.Label last_visited_doc_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RateNumericUpDown;
    }
}