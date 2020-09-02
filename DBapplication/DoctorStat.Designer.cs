namespace DBapplication
{
    partial class DoctorStat
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
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.ReportDataSet = new DBapplication.ReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDataSet1 = new DBapplication.ReportDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new DBapplication.ReportDataSetTableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 234);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(231, 234);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 8;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DoctorStatisticsReport";
            reportDataSource1.Value = this.doctorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.DoctorStatisticsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(346, 226);
            this.reportViewer1.TabIndex = 9;
            // 
            // reportDataSet1
            // 
            this.reportDataSet1.DataSetName = "ReportDataSet";
            this.reportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.reportDataSet1;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 267);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Name = "DoctorStat";
            this.Text = "DoctorStat";
            this.Load += new System.EventHandler(this.DoctorStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutbutton;
        private ReportDataSet ReportDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSet reportDataSet1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private ReportDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}