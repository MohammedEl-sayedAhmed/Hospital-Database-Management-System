using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ScanStat : Form
    {
        long _aid;
        public ScanStat(long num)
        {
            InitializeComponent();
            _aid = num;
        }

        private void ScanStat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.Scan' table. You can move, or remove it, as needed.
            this.scanTableAdapter.Fill(this.reportDataSet.Scan);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ViewsAndStatisticsForm(_aid).Show();
            this.Close();
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
