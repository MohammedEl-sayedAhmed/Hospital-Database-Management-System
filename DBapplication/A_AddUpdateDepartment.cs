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
    public partial class A_AddUpdateDepartment : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateDepartment(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectDepIDsNames();
            DepartmentsComboBox.DataSource = dt1;
            DepartmentsComboBox.DisplayMember = "Name";
            DepartmentsComboBox.ValueMember = "DepID";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void choose_dep_button_Click(object sender, EventArgs e)
        {
            DataRow Dep = controllerObj.SelectDepartment(Convert.ToInt32(DepartmentsComboBox.SelectedValue)).Rows[0];

            DepartmentNameTextBox.Text = (string)Dep["Name"];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DepartmentNameTextBox.Text == "")
            {
                MessageBox.Show("Please, enter a department name.");
            }
            else
            {
                int r = controllerObj.A_AddDepartment(DepartmentNameTextBox.Text.ToString());

                if (r > 0)
                {
                    MessageBox.Show("Department added successfully.");

                    DataTable dt1 = controllerObj.SelectDepIDsNames();
                    DepartmentsComboBox.DataSource = dt1;
                    DepartmentsComboBox.DisplayMember = "Name";
                    DepartmentsComboBox.ValueMember = "DepID";
                }
                else
                {
                    MessageBox.Show("Error in adding department.");
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DepartmentNameTextBox.Text == "")
            {
                MessageBox.Show("Please, enter a department name.");
            }
            else
            {
                int r = controllerObj.A_UpdateDepartment(Convert.ToInt32(DepartmentsComboBox.SelectedValue), DepartmentNameTextBox.Text.ToString());

                if (r > 0)
                {
                    MessageBox.Show("Department updated successfully.");

                    DataTable dt1 = controllerObj.SelectDepIDsNames();
                    DepartmentsComboBox.DataSource = dt1;
                    DepartmentsComboBox.DisplayMember = "Name";
                    DepartmentsComboBox.ValueMember = "DepID";
                }
                else
                {
                    MessageBox.Show("Error in updating department.");
                }
            }
        }
    }
}
