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
    public partial class D_AssignMedication : Form
    {

        private Controller controllerObj = new Controller();
        private long _did;
        private void D_AssignMedication_Load(object sender, EventArgs e)
        {
        }

        public D_AssignMedication(long did)
        {
            InitializeComponent();
            this._did = did;

            DataTable dt1 = controllerObj.SelectMedications();
            MedicationComboBox.DataSource = dt1;
            MedicationComboBox.DisplayMember = "Name";

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

        private void assign_medication_Click(object sender, EventArgs e)
        {
            int result;
            if (assignDosageChkBox.Checked)
            {
                if(DosageTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please insert a dosage or unckeck it checkbox.");
                }
                else
                {
                    result = controllerObj.DAssignMedications(_did, PatientComboBox.Text, MedicationComboBox.Text, DosageTextBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("The medication has been successfully assigned.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to assign the medication.");
                    }
                }
            }
            else
            {
                result = controllerObj.DAssignMedications(_did, PatientComboBox.Text, MedicationComboBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("The medication has been successfully assigned.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to assign the medication.");
                }
            }
        }
    }
}
