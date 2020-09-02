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
    public partial class ViewsAndStatisticsForm : Form
    {
        private long _aid;
        public ViewsAndStatisticsForm(long num)
        {
            InitializeComponent();
            _aid = num;
        }

        private void ViewsAndStatisticsForm_Load(object sender, EventArgs e)
        {


           
        }

        private void ScanStatButton_Click(object sender, EventArgs e)
        {
            new ScanStat(_aid).Show();
            this.Close();
        }

        private void DoctorStatButton_Click(object sender, EventArgs e)
        {
            new DoctorStat(_aid).Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminServices(_aid).Show();
            this.Close();
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void MedicineStatDutton_Click(object sender, EventArgs e)
        {
            new MedicineStat(_aid).Show();
            this.Close();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            new RecStat(_aid).Show();
            this.Close();
        }
    }
}
