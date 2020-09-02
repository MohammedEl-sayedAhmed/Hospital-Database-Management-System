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
    public partial class DoctorStat : Form
    {
        long _aid;
        public DoctorStat(long num)
        {
            InitializeComponent();
            _aid = num;
        }

        private void DoctorStat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.reportDataSet1.Doctor);

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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
