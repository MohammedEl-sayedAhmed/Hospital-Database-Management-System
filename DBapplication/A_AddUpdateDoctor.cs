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
    public partial class A_AddUpdateDoctor : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateDoctor(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectDoctorIDsNames();
            drsComboBox.DataSource = dt1;
            drsComboBox.DisplayMember = "Name";
            drsComboBox.ValueMember = "DID";

            DataTable dt2 = controllerObj.SelectDepIDsNames();
            depComboBox.DataSource = dt2;
            depComboBox.DisplayMember = "Name";
            depComboBox.ValueMember = "DepID";

            AMPMcomboBox1.DataSource = new string[] { "AM", "PM" };
            AMPMcomboBox2.DataSource = new string[] { "PM", "AM" };

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

        private void add_dr_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the doctor name, username, password, gender, age, department and salary.");
            }
            else
            {
                int r = controllerObj.A_AddDoctor(nameTextBox.Text.ToString(), 
                    usernameTextBox.Text.ToString(), 
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
                    (int)depComboBox.SelectedValue,
                    "" +(int)shiftStartNumericUpDown.Value + " " + (string)AMPMcomboBox1.SelectedValue,
                    "" + (int)shiftEndNumericUpDown.Value + " " + (string)AMPMcomboBox2.SelectedValue,
                    (int)salaryNumericUpDown.Value);

                if (r > 0)
                {
                    MessageBox.Show("Doctor added successfully.");
                    DataTable dt1 = controllerObj.SelectDoctorIDsNames();
                    drsComboBox.DataSource = dt1;
                    drsComboBox.DisplayMember = "Name";
                    drsComboBox.ValueMember = "DID";
                }
                else
                {
                    MessageBox.Show("Error in adding doctor.");
                }
            }
        }

        private void chooseDoctorToUpdButton_Click(object sender, EventArgs e)
        {
            DataRow Doctor = controllerObj.SelectDoctor(Convert.ToInt32(drsComboBox.SelectedValue)).Rows[0];

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

            depComboBox.SelectedValue = Doctor["Department_ID"];


            if (((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours < 12)
            {
                shiftStartNumericUpDown.Value = ((TimeSpan)Doctor["Start_of_Working_Hours"]).Hours;
                AMPMcomboBox1.SelectedItem = "AM";
            }
            else if (((TimeSpan)Doctor["End_of_Working_Hours"]).Hours == 12) {
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

            salaryNumericUpDown.Value = (int)Doctor["Salary"];
        }

        private void upd_dr_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || ((!maleRadioButton.Checked) && (!femaleRadioButton.Checked)))
            {
                MessageBox.Show("Please, insert at least the doctor name, username, password, gender, age, department and salary.");
            }
            else
            {
                int r = controllerObj.A_UpdateDoctor(Convert.ToInt32(drsComboBox.SelectedValue),
                    nameTextBox.Text.ToString(),
                    usernameTextBox.Text.ToString(),
                    passwordTextBox.Text.ToString(),
                    maleRadioButton.Checked ? "M" : "F",
                    (int)ageNumericUpDown.Value,
                    mobileNumTextBox.Text.ToString(),
                    addressTextBox.Text.ToString(),
                    (int)depComboBox.SelectedValue,
                    "" + (int)shiftStartNumericUpDown.Value + " " + (string)AMPMcomboBox1.SelectedValue,
                    "" + (int)shiftEndNumericUpDown.Value + " " + (string)AMPMcomboBox2.SelectedValue,
                    (int)salaryNumericUpDown.Value);

                if (r > 0)
                {
                    MessageBox.Show("Doctor updated successfully.");
                    DataTable dt1 = controllerObj.SelectDoctorIDsNames();
                    drsComboBox.DataSource = dt1;
                    drsComboBox.DisplayMember = "Name";
                    drsComboBox.ValueMember = "DID";
                }
                else
                {
                    MessageBox.Show("Error in updating doctor.");
                }
            }
        }
    }
}
