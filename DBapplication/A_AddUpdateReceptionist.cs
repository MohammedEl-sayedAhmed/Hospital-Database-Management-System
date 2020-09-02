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
    public partial class A_AddUpdateReceptionist : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateReceptionist(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectReceptionistIDsNames();
            recepsComboBox.DataSource = dt1;
            recepsComboBox.DisplayMember = "Name";
            recepsComboBox.ValueMember = "RecID";
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        

        private void add_recep_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the receptionist name, username, password, gender, age and salary.");
            }
            else
            {
                int r = controllerObj.A_AddReceptionist(nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
                    (int)salaryNumericUpDown.Value);

                if (r > 0)
                {
                    MessageBox.Show("Receptionist added successfully.");
                    DataTable dt1 = controllerObj.SelectReceptionistIDsNames();
                    recepsComboBox.DataSource = dt1;
                    recepsComboBox.DisplayMember = "Name";
                    recepsComboBox.ValueMember = "RecID";
                }
                else
                {
                    MessageBox.Show("Error in adding receptionist.");
                }
            }
        }

        private void chooseRecepToUpdButton_Click(object sender, EventArgs e)
        {
            DataRow Receptionist = controllerObj.SelectReceptionist(Convert.ToInt32(recepsComboBox.SelectedValue)).Rows[0];

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

            salaryNumericUpDown.Value = (int)Receptionist["Salary"];
        }

        private void upd_recep_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the receptionist name, username, password, gender, age and salary.");
            }
            else
            {
                int r = controllerObj.A_UpdateReceptionist(Convert.ToInt32(recepsComboBox.SelectedValue),
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
                    (int)salaryNumericUpDown.Value);

                if (r > 0)
                {
                    MessageBox.Show("Receptionist updated successfully.");
                    DataTable dt1 = controllerObj.SelectReceptionistIDsNames();
                    recepsComboBox.DataSource = dt1;
                    recepsComboBox.DisplayMember = "Name";
                    recepsComboBox.ValueMember = "RecID";
                }
                else
                {
                    MessageBox.Show("Error in updating receptionist.");
                }
            }
        }
    }
}
