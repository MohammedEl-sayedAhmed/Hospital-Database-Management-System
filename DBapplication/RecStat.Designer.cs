namespace DBapplication
{
    partial class RecStat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDataSet = new DBapplication.ReportDataSet();
            this.receptionistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptionistTableAdapter = new DBapplication.ReportDataSetTableAdapters.ReceptionistTableAdapter();
            this.receptionistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 265);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(203, 265);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 10;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "RecStatisticsReport";
            reportDataSource1.Value = this.receptionistBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.RecStatisticsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(325, 246);
            this.reportViewer1.TabIndex = 11;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptionistBindingSource
            // 
            this.receptionistBindingSource.DataMember = "Receptionist";
            this.receptionistBindingSource.DataSource = this.reportDataSet;
            // 
            // receptionistTableAdapter
            // 
            this.receptionistTableAdapter.ClearBeforeFill = true;
            // 
            // receptionistBindingSource1
            // 
            this.receptionistBindingSource1.DataMember = "Receptionist";
            this.receptionistBindingSource1.DataSource = this.reportDataSet;
            // 
            // RecStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 300);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Name = "RecStat";
            this.Text = "RecStat";
            this.Load += new System.EventHandler(this.RecStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource receptionistBindingSource;
        private ReportDataSetTableAdapters.ReceptionistTableAdapter receptionistTableAdapter;
        private System.Windows.Forms.BindingSource receptionistBindingSource1;
    }
}