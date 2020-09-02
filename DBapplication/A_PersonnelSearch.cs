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
    public partial class A_PersonnelSearch : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_PersonnelSearch(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            TypeComboBox.DataSource = new string[] { "Patient", "Doctor", "Receptionist", "Admin" };
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

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.SelectPersonnel((string)TypeComboBox.SelectedValue, null);
            resultDataGridView.DataSource = dt2;
            resultDataGridView.Refresh();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)TypeComboBox.SelectedValue == "Patient")
            {
                DataTable dt1 = controllerObj.SelectPatientIDsNames();
                NameComboBox.DataSource = dt1;
                NameComboBox.DisplayMember = "Name";
                NameComboBox.ValueMember = "PID";
            }
            else if ((string)TypeComboBox.SelectedValue == "Doctor")
            {
                DataTable dt1 = controllerObj.SelectDoctorIDsNames();
                NameComboBox.DataSource = dt1;
                NameComboBox.DisplayMember = "Name";
                NameComboBox.ValueMember = "DID";
            }
            else if ((string)TypeComboBox.SelectedValue == "Receptionist")
            {
                DataTable dt1 = controllerObj.SelectReceptionistIDsNames();
                NameComboBox.DataSource = dt1;
                NameComboBox.DisplayMember = "Name";
                NameComboBox.ValueMember = "RecID";
            }
            else if ((string)TypeComboBox.SelectedValue == "Admin")
            {
                DataTable dt1 = controllerObj.SelectAdminIDsNames();
                NameComboBox.DataSource = dt1;
                NameComboBox.DisplayMember = "Name";
                NameComboBox.ValueMember = "AID";
            }
        }

        private void ViewThisPersonButton_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.SelectPersonnel((string)TypeComboBox.SelectedValue, Convert.ToInt32(NameComboBox.SelectedValue));
            resultDataGridView.DataSource = dt3;
            resultDataGridView.Refresh();
        }
    }
}
