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
    public partial class RecStat : Form
    {
        long _aid;
        public RecStat(long num)
        {
            InitializeComponent();
            _aid = num;
        }

        private void RecStat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.Receptionist' table. You can move, or remove it, as needed.
            this.receptionistTableAdapter.Fill(this.reportDataSet.Receptionist);

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
