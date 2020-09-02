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
    public partial class D_ViewSchedule : Form
    {
        private long _did;
        Controller controllerObj;

        public D_ViewSchedule(long did)
        {
            InitializeComponent();
            this._did = did;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.ViewDoctorSchedule((int)_did);
            doctor_view_schedule.DataSource = dt1;
            doctor_view_schedule.Refresh();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new DoctorServices((long)_did).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
