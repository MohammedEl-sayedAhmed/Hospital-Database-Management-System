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
    public partial class D_UpdateInfo : Form
    {
        private long _did;
        Controller controllerObj;

        public D_UpdateInfo(long did)
        {
            InitializeComponent();
            this._did = did;
            controllerObj = new Controller();

            AMPMcomboBox1.DataSource = new string[] { "AM", "PM" };
            AMPMcomboBox2.DataSource = new string[] { "AM", "PM" };

            showInfo();
        }

        private void showInfo()
        {
            DataRow Doctor = controllerObj.SelectDoctor((int)_did).Rows[0];

            nameTextBox.Text = (string)Doctor["Name"];
            usernameTextBox.Text = (string)Doctor["Username"];
            passwordTextBox.Text = (string)Doctor["Password"];

            if ((string)Doctor["Gender"] == "M")
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }

            ageNumericUpDown.Value = (int)Doctor["Age"];

            if (Doctor["Mobile_Number"] == DBNull.Value)
            {
                mobileNumTextBox.Text = "";
            }
            else
            {
                mobileNumTextBox.Text = (string)Doctor["Mobile_Number"];
            }

            if (Doctor["Address"] == DBNull.Value)
            {
                addressTextBox.Text = "";
            }
            else
            {
                addressTextBox.Text = (string)Doctor["Address"];
            }


            if (((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours < 12)
            {
                shiftStartNumericUpDown.Value = ((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours;
                AMPMcomboBox1.SelectedItem = "AM";
            }
            else if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours == 12)
            {
                shiftStartNumericUpDown.Value = ((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours;
                AMPMcomboBox1.SelectedItem = "PM";
            }
            else if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours > 12)
            {
                shiftStartNumericUpDown.Value = ((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours - 12;
                AMPMcomboBox1.SelectedItem = "PM";
            }


            if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours < 12)
            {
                shiftEndNumericUpDown.Value = ((TimeSpan)Doctor["End_of_Working_Hours"]).Hours;
                AMPMcomboBox2.SelectedItem = "AM";
            }
            else if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours == 12)
            {
                shiftEndNumericUpDown.Value = ((TimeSpan)Doctor["End_of_Working_Hours"]).Hours;
                AMPMcomboBox2.SelectedItem = "PM";
            }
            else if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours > 12)
            {
                shiftEndNumericUpDown.Value = ((TimeSpan)Doctor["End_of_Working_Hours"]).Hours - 12;
                AMPMcomboBox2.SelectedItem = "PM";
            }
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

        private void upd_info_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the name, username, password, gender and age.");
            }
            else
            {
                int r = controllerObj.A_UpdateDoctor((int)_did,
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
                    -1,
                    "" + (int)shiftStartNumericUpDown.Value + " " + (string)AMPMcomboBox1.SelectedValue,
                    "" + (int)shiftEndNumericUpDown.Value + " " + (string)AMPMcomboBox2.SelectedValue,
                    -1);

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
