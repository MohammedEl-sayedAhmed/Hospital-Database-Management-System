namespace DBapplication
{
    partial class R_PersonnelSearch
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(227, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Patient"});
            this.TypeComboBox.Location = new System.Drawing.Point(296, 34);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(160, 28);
            this.TypeComboBox.TabIndex = 7;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(8, 95);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersWidth = 51;
            this.resultDataGridView.Size = new System.Drawing.Size(668, 259);
            this.resultDataGridView.TabIndex = 8;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 443);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(576, 443);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(100, 28);
            this.LogOutButton.TabIndex = 10;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.Location = new System.Drawing.Point(8, 374);
            this.ViewAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(100, 28);
            this.ViewAllButton.TabIndex = 11;
            this.ViewAllButton.Text = "View All";
            this.ViewAllButton.UseVisualStyleBackColor = true;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(576, 374);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(100, 28);
            this.ViewButton.TabIndex = 12;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // NameComboBox
            // 
            this.NameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient",
            "Receptionist"});
            this.NameComboBox.Location = new System.Drawing.Point(408, 374);
            this.NameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(160, 28);
            this.NameComboBox.TabIndex = 13;
            // 
            // R_PersonnelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 489);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "R_PersonnelSearch";
            this.Text = "R_PersonnelSearch";
            this.Load += new System.EventHandler(this.R_PersonnelSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ComboBox NameComboBox;
    }
}