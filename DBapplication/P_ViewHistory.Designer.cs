namespace DBapplication
{
    partial class P_ViewHistory
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewHistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(231, 352);
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
            this.back_button.Location = new System.Drawing.Point(119, 352);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 29;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(177, 54);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(209, 24);
            this.TypeComboBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "History Of:";
            // 
            // HistoryDataGridView
            // 
            this.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataGridView.Location = new System.Drawing.Point(68, 103);
            this.HistoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryDataGridView.Name = "HistoryDataGridView";
            this.HistoryDataGridView.RowHeadersWidth = 51;
            this.HistoryDataGridView.Size = new System.Drawing.Size(320, 185);
            this.HistoryDataGridView.TabIndex = 33;
            this.HistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewHistButton
            // 
            this.ViewHistButton.Location = new System.Drawing.Point(157, 308);
            this.ViewHistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewHistButton.Name = "ViewHistButton";
            this.ViewHistButton.Size = new System.Drawing.Size(139, 25);
            this.ViewHistButton.TabIndex = 34;
            this.ViewHistButton.Text = "View History";
            this.ViewHistButton.UseVisualStyleBackColor = true;
            this.ViewHistButton.Click += new System.EventHandler(this.ViewHistButton_Click);
            // 
            // P_ViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 401);
            this.Controls.Add(this.ViewHistButton);
            this.Controls.Add(this.HistoryDataGridView);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "P_ViewHistory";
            this.Text = "P_ViewHistory";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView HistoryDataGridView;
        private System.Windows.Forms.Button ViewHistButton;
    }
}