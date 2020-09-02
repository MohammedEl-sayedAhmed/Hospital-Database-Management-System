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
    public partial class D_UpdatePatientDiagnosis : Form
    {
        private Controller controllerObj = new Controller();
        private long _did;

        public D_UpdatePatientDiagnosis(long did)
        {
            InitializeComponent();
            this._did = did;
            DataTable dt2 = controllerObj.SelectNonReleasedPatients(_did);
            PatientComboBox.DataSource = dt2;
            PatientComboBox.DisplayMember = "Name";
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

        private void upd_diag_button_Click(object sender, EventArgs e)
        {
            if (diagnosisTextBox.Text=="")
            {
                MessageBox.Show("Please write a diagnosis");
            }
            else
            {
                int result = controllerObj.UpdatePatientDiagnosis(PatientComboBox.Text, _did, diagnosisTextBox.Text);
                if (result >0)
                {
                    MessageBox.Show("The patient's diagnosis has been successfuly updated");
                }
                else 
                {
                    MessageBox.Show("There was an error with updating the patient's diagnosis");
                }
            }
        }
    }
}
