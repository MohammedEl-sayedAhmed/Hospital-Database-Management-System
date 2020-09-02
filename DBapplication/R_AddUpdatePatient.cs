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
    public partial class R_AddUpdatePatient : Form
    {
        private long _recid;
        Controller controllerObj;

        public R_AddUpdatePatient(long recid)
        {
            InitializeComponent();
            this._recid = recid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectPatientIDsNames();
            patsComboBox.DataSource = dt1;
            patsComboBox.DisplayMember = "Name";
            patsComboBox.ValueMember = "PID";
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
            this.Close();
        }

        private void add_pat_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the patient name, username, password, gender and age");
            }
            else
            {
                int r = controllerObj.R_AddPatient(nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString());

                if (r > 0)
                {
                    MessageBox.Show("Patient added successfully.");

                    DataTable dt1 = controllerObj.SelectPatientIDsNames();
                    patsComboBox.DataSource = dt1;
                    patsComboBox.DisplayMember = "Name";
                    patsComboBox.ValueMember = "PID";
                }
                else
                {
                    MessageBox.Show("Error in adding patient.");
                }
            }
        }

        private void choose_pat_button_Click(object sender, EventArgs e)
        {
            DataRow Patient = controllerObj.SelectPatient(Convert.ToInt32(patsComboBox.SelectedValue)).Rows[0];

            nameTextBox.Text = (string)Patient["Name"];
            usernameTextBox.Text = (string)Patient["Username"];
            passwordTextBox.Text = (string)Patient["Password"];

            if ((string)Patient["Gender"] == "M")
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }

            ageNumericUpDown.Value = (int)Patient["Age"];

            if (Patient["Mobile_Number"] == DBNull.Value)
            {
                mobileNumTextBox.Text = "";
            }
            else
            {
                mobileNumTextBox.Text = (string)Patient["Mobile_Number"];
            }

            if (Patient["Address"] == DBNull.Value)
            {
                addressTextBox.Text = "";
            }
            else
            {
                addressTextBox.Text = (string)Patient["Address"];
            }
        }

        private void upd_pat_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the patient name, username, password, gender, and age.");
            }
            else
            {
                int r = controllerObj.R_UpdatePatient(Convert.ToInt32(patsComboBox.SelectedValue),
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString());

                if (r > 0)
                {
                    MessageBox.Show("Patient updated successfully.");
                    DataTable dt1 = controllerObj.SelectPatientIDsNames();
                    patsComboBox.DataSource = dt1;
                    patsComboBox.DisplayMember = "Name";
                    patsComboBox.ValueMember = "PID";
                }
                else
                {
                    MessageBox.Show("Error in updating patient.");
                }
            }
        }
    }
}
