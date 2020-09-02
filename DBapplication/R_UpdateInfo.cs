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
    public partial class R_UpdateInfo : Form
    {
        private long _recid;
        Controller controllerObj;

        public R_UpdateInfo(long recid)
        {
            InitializeComponent();
            this._recid = recid;
            controllerObj = new Controller();

            showInfo();
        }

        private void showInfo()
        {
            DataRow Receptionist = controllerObj.SelectReceptionist((int)_recid).Rows[0];

            nameTextBox.Text = (string)Receptionist["Name"];
            usernameTextBox.Text = (string)Receptionist["Username"];
            passwordTextBox.Text = (string)Receptionist["Password"];

            if ((string)Receptionist["Gender"] == "M")
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }

            ageNumericUpDown.Value = (int)Receptionist["Age"];

            if (Receptionist["Mobile_Number"] == DBNull.Value)
            {
                mobileNumTextBox.Text = "";
            }
            else
            {
                mobileNumTextBox.Text = (string)Receptionist["Mobile_Number"];
            }

            if (Receptionist["Address"] == DBNull.Value)
            {
                addressTextBox.Text = "";
            }
            else
            {
                addressTextBox.Text = (string)Receptionist["Address"];
            }
        }

        private void R_UpdateInfo_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
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
                int r = controllerObj.A_UpdateReceptionist((int)_recid,
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
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
