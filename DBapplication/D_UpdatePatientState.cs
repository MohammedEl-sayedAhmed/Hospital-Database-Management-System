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
    public partial class D_UpdatePatientState : Form
    {
        private Controller controllerObj = new Controller();
        private long _did;

        public D_UpdatePatientState(long did)
        {
            InitializeComponent();
            this._did = did;

            StateComboBox.Items.Add("Being Examined");
            StateComboBox.Items.Add("Getting Scans");
            StateComboBox.Items.Add("Buying Medications");
            StateComboBox.Items.Add("Released");
            DataTable dt2 = controllerObj.SelectNonReleasedPatients(_did);
            PatientComboBox.DataSource = dt2;
            PatientComboBox.DisplayMember = "Name";
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

        private void uod_state_button_Click(object sender, EventArgs e)
        {
            if(StateComboBox.Text =="")
            {
                MessageBox.Show("Please choose s state.");
            }
            else
            {
                int result = controllerObj.UpdatePatientState(PatientComboBox.Text, _did, StateComboBox.Text);
                
                if(result >0)
                {
                    MessageBox.Show("The patient's state has been successfuly updated.");
                    DataTable dt3 = controllerObj.SelectNonReleasedPatients(_did);
                    PatientComboBox.DataSource = dt3;
                    PatientComboBox.DisplayMember = "Name";
                }
                else
                {
                    MessageBox.Show("There was an error with updating the patient's state.");
                }
            }
            
        }
    }
}
