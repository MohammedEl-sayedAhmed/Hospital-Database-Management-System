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
    public partial class A_ViewPatientRegistrations : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_ViewPatientRegistrations(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectPatientIDsNames();
            PatientRegistrationCombobox.DataSource = dt1;
            PatientRegistrationCombobox.DisplayMember = "Name";
            PatientRegistrationCombobox.ValueMember = "PID";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void view_registration_btn_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.ViewPatientRegistrations(Convert.ToInt32(PatientRegistrationCombobox.SelectedValue));
            patientRegistrationGridView.DataSource = dt2;
            patientRegistrationGridView.Refresh();
        }

        private void A_ViewPatientRegistrations_Load(object sender, EventArgs e)
        {

        }
    }
}
