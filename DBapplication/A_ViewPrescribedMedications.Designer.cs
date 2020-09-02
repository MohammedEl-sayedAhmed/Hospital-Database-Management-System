namespace DBapplication
{
    partial class A_ViewPrescribedMedications
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
            this.AllPrescrbdMediGridView = new System.Windows.Forms.DataGridView();
            this.MedCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_PrescrbdMedi_btn = new System.Windows.Forms.Button();
            this.one_med_pres_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllPrescrbdMediGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_med_pres_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPrescrbdMediGridView
            // 
            this.AllPrescrbdMediGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPrescrbdMediGridView.Location = new System.Drawing.Point(45, 90);
            this.AllPrescrbdMediGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllPrescrbdMediGridView.Name = "AllPrescrbdMediGridView";
            this.AllPrescrbdMediGridView.RowHeadersWidth = 51;
            this.AllPrescrbdMediGridView.Size = new System.Drawing.Size(359, 429);
            this.AllPrescrbdMediGridView.TabIndex = 120;
            this.AllPrescrbdMediGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderedScansGridView_CellContentClick);
            // 
            // MedCombobox
            // 
            this.MedCombobox.FormattingEnabled = true;
            this.MedCombobox.Location = new System.Drawing.Point(603, 34);
            this.MedCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MedCombobox.Name = "MedCombobox";
            this.MedCombobox.Size = new System.Drawing.Size(209, 24);
            this.MedCombobox.TabIndex = 119;
            this.MedCombobox.SelectedIndexChanged += new System.EventHandler(this.OrderedScansCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(476, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Medication:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(468, 551);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 117;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(299, 551);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 116;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_PrescrbdMedi_btn
            // 
            this.view_PrescrbdMedi_btn.Location = new System.Drawing.Point(530, 486);
            this.view_PrescrbdMedi_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_PrescrbdMedi_btn.Name = "view_PrescrbdMedi_btn";
            this.view_PrescrbdMedi_btn.Size = new System.Drawing.Size(240, 33);
            this.view_PrescrbdMedi_btn.TabIndex = 115;
            this.view_PrescrbdMedi_btn.Text = "View Medication Prescriptions";
            this.view_PrescrbdMedi_btn.UseVisualStyleBackColor = true;
            this.view_PrescrbdMedi_btn.Click += new System.EventHandler(this.view_orderScans_btn_Click);
            // 
            // one_med_pres_dataGridView
            // 
            this.one_med_pres_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.one_med_pres_dataGridView.Location = new System.Drawing.Point(468, 90);
            this.one_med_pres_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.one_med_pres_dataGridView.Name = "one_med_pres_dataGridView";
            this.one_med_pres_dataGridView.RowHeadersWidth = 51;
            this.one_med_pres_dataGridView.Size = new System.Drawing.Size(359, 370);
            this.one_med_pres_dataGridView.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(123, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "All Prescribed Medications";
            // 
            // A_ViewPrescribedMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.one_med_pres_dataGridView);
            this.Controls.Add(this.AllPrescrbdMediGridView);
            this.Controls.Add(this.MedCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_PrescrbdMedi_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A_ViewPrescribedMedications";
            this.Text = "A_ViewPrescribedMedications";
            ((System.ComponentModel.ISupportInitialize)(this.AllPrescrbdMediGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_med_pres_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPrescrbdMediGridView;
        private System.Windows.Forms.ComboBox MedCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_PrescrbdMedi_btn;
        private System.Windows.Forms.DataGridView one_med_pres_dataGridView;
        private System.Windows.Forms.Label label2;
    }
}