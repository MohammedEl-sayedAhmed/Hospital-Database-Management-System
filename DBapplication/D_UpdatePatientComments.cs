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
    public partial class D_UpdatePatientComments : Form
    {
        private Controller controllerObj = new Controller();
        private long _did;

        public D_UpdatePatientComments(long did)
        {
            InitializeComponent();
            this._did = did;
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

        private void upd_comm_button_Click(object sender, EventArgs e)
        {
            if (commentsTextBox.Text == "")
            {
                MessageBox.Show("Please write a comment");
            }
            else
            {
                int result = controllerObj.UpdatePatientComments(PatientComboBox.Text, _did, commentsTextBox.Text);

                if (result > 0)
                {
                    MessageBox.Show("The patient's comments has been successfuly updated.");
                    
                }
                else
                {
                    MessageBox.Show("There was an error with updating the patient's comments.");
                }
            }
        }
    }
}
