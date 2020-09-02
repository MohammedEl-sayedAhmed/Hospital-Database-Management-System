namespace DBapplication
{
    partial class ScanStat
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.scanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new DBapplication.ReportDataSet();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.scanTableAdapter = new DBapplication.ReportDataSetTableAdapters.ScanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scanBindingSource
            // 
            this.scanBindingSource.DataMember = "Scan";
            this.scanBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 251);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(172, 251);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 11;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ScanStatisticsReport";
            reportDataSource1.Value = this.scanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.ScanStatisticsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(297, 246);
            this.reportViewer1.TabIndex = 12;
            // 
            // scanTableAdapter
            // 
            this.scanTableAdapter.ClearBeforeFill = true;
            // 
            // ScanStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 286);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Name = "ScanStat";
            this.Text = "OrderedScanStat";
            this.Load += new System.EventHandler(this.ScanStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource scanBindingSource;
        private ReportDataSetTableAdapters.ScanTableAdapter scanTableAdapter;
    }
}