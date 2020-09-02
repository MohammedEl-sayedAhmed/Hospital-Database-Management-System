namespace DBapplication
{
    partial class A_ViewDoctorRatings
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
            this.label2 = new System.Windows.Forms.Label();
            this.doctorRatingGridView = new System.Windows.Forms.DataGridView();
            this.DoctorRatingCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view_rate_btn = new System.Windows.Forms.Button();
            this.avgRatingsDataGridView = new System.Windows.Forms.DataGridView();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorRatingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgRatingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(113, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Average Doctor Ratings";
            // 
            // doctorRatingGridView
            // 
            this.doctorRatingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorRatingGridView.Location = new System.Drawing.Point(429, 74);
            this.doctorRatingGridView.Margin = new System.Windows.Forms.Padding(4);
            this.doctorRatingGridView.Name = "doctorRatingGridView";
            this.doctorRatingGridView.RowHeadersWidth = 51;
            this.doctorRatingGridView.Size = new System.Drawing.Size(359, 399);
            this.doctorRatingGridView.TabIndex = 109;
            // 
            // DoctorRatingCombobox
            // 
            this.DoctorRatingCombobox.FormattingEnabled = true;
            this.DoctorRatingCombobox.Location = new System.Drawing.Point(569, 31);
            this.DoctorRatingCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorRatingCombobox.Name = "DoctorRatingCombobox";
            this.DoctorRatingCombobox.Size = new System.Drawing.Size(209, 24);
            this.DoctorRatingCombobox.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(437, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Doctor Name:";
            // 
            // view_rate_btn
            // 
            this.view_rate_btn.Location = new System.Drawing.Point(539, 491);
            this.view_rate_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_rate_btn.Name = "view_rate_btn";
            this.view_rate_btn.Size = new System.Drawing.Size(139, 33);
            this.view_rate_btn.TabIndex = 104;
            this.view_rate_btn.Text = "View Ratings";
            this.view_rate_btn.UseVisualStyleBackColor = true;
            this.view_rate_btn.Click += new System.EventHandler(this.view_rate_btn_Click);
            // 
            // avgRatingsDataGridView
            // 
            this.avgRatingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgRatingsDataGridView.Location = new System.Drawing.Point(24, 74);
            this.avgRatingsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.avgRatingsDataGridView.Name = "avgRatingsDataGridView";
            this.avgRatingsDataGridView.RowHeadersWidth = 51;
            this.avgRatingsDataGridView.Size = new System.Drawing.Size(359, 450);
            this.avgRatingsDataGridView.TabIndex = 111;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(429, 563);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(148, 27);
            this.logout_button.TabIndex = 113;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click_1);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(235, 563);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(148, 27);
            this.back_button.TabIndex = 112;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // A_ViewDoctorRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 619);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.avgRatingsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doctorRatingGridView);
            this.Controls.Add(this.DoctorRatingCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_rate_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_ViewDoctorRatings";
            this.Text = "A_ViewDoctorRatings";
            this.Load += new System.EventHandler(this.A_ViewDoctorRatings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorRatingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgRatingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView doctorRatingGridView;
        private System.Windows.Forms.ComboBox DoctorRatingCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_rate_btn;
        private System.Windows.Forms.DataGridView avgRatingsDataGridView;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
    }
}