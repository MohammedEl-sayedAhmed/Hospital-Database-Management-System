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
    public partial class D_RequestScan : Form
    {
        private Controller controllerObj = new Controller();
  

        private long _did;

        public D_RequestScan(long did)
        {
            InitializeComponent();
            this._did = did;
            DataTable dt1 = controllerObj.SelectScans();
            ScanComboBox.DataSource = dt1;
            ScanComboBox.DisplayMember = "Name";
            DataTable dt2 = controllerObj.SelectNonReleasedPatients(_did);
            PatientComboBox.DataSource = dt2;
            PatientComboBox.DisplayMember = "Name";
        }

        private void ScanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void D_RequestScan_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new DoctorServices((long)_did).Show();
            this.Close();
        }

        private void requst_scan_btn_Click(object sender, EventArgs e)
        {
            int result = controllerObj.DRequestScans(_did, PatientComboBox.Text, ScanComboBox.Text);

            if (result >0)
            {
                string scanEndTime = controllerObj.GetScanEndTime(_did, PatientComboBox.Text, ScanComboBox.Text);
                MessageBox.Show("Scan has been successfully requested! You should conduct your scan before " + scanEndTime+ ".");
            }
            else
            {
                MessageBox.Show("Scan request failed.");
            }
        }
    }
}
