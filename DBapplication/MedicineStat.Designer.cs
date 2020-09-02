namespace DBapplication
{
    partial class MedicineStat
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
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new DBapplication.ReportDataSet();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.medicationTableAdapter = new DBapplication.ReportDataSetTableAdapters.MedicationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataMember = "Medication";
            this.medicationBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(219, 219);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 9;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 219);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "MedicineStatisticsReport";
            reportDataSource1.Value = this.medicationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.MedicineStatisticsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(344, 217);
            this.reportViewer1.TabIndex = 10;
            // 
            // medicationTableAdapter
            // 
            this.medicationTableAdapter.ClearBeforeFill = true;
            // 
            // MedicineStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 254);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Name = "MedicineStat";
            this.Text = "PrescribedMedicineStat";
            this.Load += new System.EventHandler(this.MedicineStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button BackButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private ReportDataSetTableAdapters.MedicationTableAdapter medicationTableAdapter;
    }
}