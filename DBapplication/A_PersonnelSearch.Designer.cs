namespace DBapplication
{
    partial class A_PersonnelSearch
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ViewThisPersonButton = new System.Windows.Forms.Button();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(344, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "View:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(218, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient",
            "Receptionist"});
            this.TypeComboBox.Location = new System.Drawing.Point(329, 31);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(160, 28);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(16, 91);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersWidth = 51;
            this.resultDataGridView.Size = new System.Drawing.Size(656, 214);
            this.resultDataGridView.TabIndex = 4;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(572, 409);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(100, 28);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(20, 409);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewThisPersonButton
            // 
            this.ViewThisPersonButton.Location = new System.Drawing.Point(572, 334);
            this.ViewThisPersonButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewThisPersonButton.Name = "ViewThisPersonButton";
            this.ViewThisPersonButton.Size = new System.Drawing.Size(100, 28);
            this.ViewThisPersonButton.TabIndex = 8;
            this.ViewThisPersonButton.Text = "View";
            this.ViewThisPersonButton.UseVisualStyleBackColor = true;
            this.ViewThisPersonButton.Click += new System.EventHandler(this.ViewThisPersonButton_Click);
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.Location = new System.Drawing.Point(16, 334);
            this.ViewAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(100, 28);
            this.ViewAllButton.TabIndex = 9;
            this.ViewAllButton.Text = "View All";
            this.ViewAllButton.UseVisualStyleBackColor = true;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
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
            this.NameComboBox.Location = new System.Drawing.Point(404, 334);
            this.NameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(160, 28);
            this.NameComboBox.TabIndex = 10;
            // 
            // A_PersonnelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 457);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.ViewThisPersonButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_PersonnelSearch";
            this.Text = "A_PersonnelSearch";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ViewThisPersonButton;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.ComboBox NameComboBox;
    }
}