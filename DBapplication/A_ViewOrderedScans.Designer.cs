namespace DBapplication
{
    partial class A_ViewOrderedScans
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
            this.OrderedScansGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.oneScanDataGridView = new System.Windows.Forms.DataGridView();
            this.scansCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.view_scan_orders_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedScansGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneScanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderedScansGridView
            // 
            this.OrderedScansGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderedScansGridView.Location = new System.Drawing.Point(35, 65);
            this.OrderedScansGridView.Margin = new System.Windows.Forms.Padding(4);
            this.OrderedScansGridView.Name = "OrderedScansGridView";
            this.OrderedScansGridView.RowHeadersWidth = 51;
            this.OrderedScansGridView.Size = new System.Drawing.Size(359, 391);
            this.OrderedScansGridView.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "All Ordered Scans";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(444, 482);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 111;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(289, 482);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 110;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // oneScanDataGridView
            // 
            this.oneScanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oneScanDataGridView.Location = new System.Drawing.Point(444, 65);
            this.oneScanDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.oneScanDataGridView.Name = "oneScanDataGridView";
            this.oneScanDataGridView.RowHeadersWidth = 51;
            this.oneScanDataGridView.Size = new System.Drawing.Size(359, 339);
            this.oneScanDataGridView.TabIndex = 115;
            // 
            // scansCombobox
            // 
            this.scansCombobox.FormattingEnabled = true;
            this.scansCombobox.Location = new System.Drawing.Point(561, 20);
            this.scansCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scansCombobox.Name = "scansCombobox";
            this.scansCombobox.Size = new System.Drawing.Size(209, 24);
            this.scansCombobox.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(477, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "Scan:";
            // 
            // view_scan_orders_btn
            // 
            this.view_scan_orders_btn.Location = new System.Drawing.Point(561, 423);
            this.view_scan_orders_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_scan_orders_btn.Name = "view_scan_orders_btn";
            this.view_scan_orders_btn.Size = new System.Drawing.Size(139, 33);
            this.view_scan_orders_btn.TabIndex = 122;
            this.view_scan_orders_btn.Text = "View Scan Orders";
            this.view_scan_orders_btn.UseVisualStyleBackColor = true;
            this.view_scan_orders_btn.Click += new System.EventHandler(this.view_scan_orders_btn_Click);
            // 
            // A_ViewOrderedScans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 531);
            this.Controls.Add(this.view_scan_orders_btn);
            this.Controls.Add(this.scansCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oneScanDataGridView);
            this.Controls.Add(this.OrderedScansGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_ViewOrderedScans";
            this.Text = "A_ViewOrderedScans";
            ((System.ComponentModel.ISupportInitialize)(this.OrderedScansGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneScanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderedScansGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView oneScanDataGridView;
        private System.Windows.Forms.ComboBox scansCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button view_scan_orders_btn;
    }
}