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
    public partial class P_UpdateInfo : Form
    {
        private long _pid;
        Controller controllerObj;

        public P_UpdateInfo(long pid)
        {
            InitializeComponent();
            this._pid = pid;
            controllerObj = new Controller();

            showInfo();
        }

        private void showInfo()
        {
            DataRow Patient = controllerObj.SelectPatient((int)_pid).Rows[0];

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

        private void back_button_Click(object sender, EventArgs e)
        {
            new PatientServices((long)_pid).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void upd_info_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the name, username, password, gender, and age.");
            }
            else
            {
                int r = controllerObj.R_UpdatePatient((int)_pid,
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString());

                if (r > 0)
                {
                    MessageBox.Show("Information updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error in updating information.");
                }
            }
        }
    }
}
