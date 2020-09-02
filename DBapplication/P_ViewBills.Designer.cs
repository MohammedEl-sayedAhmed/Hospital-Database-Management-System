namespace DBapplication
{
    partial class P_ViewBills
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
            this.BillsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(443, 494);
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
            this.back_button.Location = new System.Drawing.Point(331, 494);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 29;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // BillsDataGridView
            // 
            this.BillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDataGridView.Location = new System.Drawing.Point(17, 72);
            this.BillsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.BillsDataGridView.Name = "BillsDataGridView";
            this.BillsDataGridView.RowHeadersWidth = 51;
            this.BillsDataGridView.Size = new System.Drawing.Size(848, 382);
            this.BillsDataGridView.TabIndex = 31;
            this.BillsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(400, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "All Bills";
            // 
            // P_ViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillsDataGridView);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "P_ViewBills";
            this.Text = "P_ViewBills";
            ((System.ComponentModel.ISupportInitialize)(this.BillsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView BillsDataGridView;
        private System.Windows.Forms.Label label1;
    }
}