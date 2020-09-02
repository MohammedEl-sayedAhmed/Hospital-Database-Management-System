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
    public partial class DoctorServices : Form
    {
        private long _did;

        public DoctorServices(long did)
        {
            InitializeComponent();
            this._did = did;
        }

        private void DoctorServices_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void assign_med_button_Click(object sender, EventArgs e)
        {
            new D_AssignMedication((long)_did).Show();
            this.Close();
        }

        private void req_scan_button_Click(object sender, EventArgs e)
        {
            new D_RequestScan((long)_did).Show();
            this.Close();
        }

        private void pat_state_button_Click(object sender, EventArgs e)
        {
            new D_UpdatePatientState((long)_did).Show();
            this.Close();
        }

        private void pat_diag_button_Click(object sender, EventArgs e)
        {
            new D_UpdatePatientDiagnosis((long)_did).Show();
            this.Close();
        }

        private void pat_comments_button_Click(object sender, EventArgs e)
        {
            new D_UpdatePatientComments((long)_did).Show();
            this.Close();
        }

        private void view_sched_button_Click(object sender, EventArgs e)
        {
            new D_ViewSchedule((long)_did).Show();
            this.Close();
        }

        private void update_info_button_Click(object sender, EventArgs e)
        {
            new D_UpdateInfo((long)_did).Show();
            this.Close();
        }
    }
}
