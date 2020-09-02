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
    public partial class R_PersonnelSearch : Form
    {
        private long _recid;
        Controller controllerObj;

        public R_PersonnelSearch(long recid)
        {
            InitializeComponent();
            this._recid = recid;
            controllerObj = new Controller();

            TypeComboBox.DataSource = new string[] { "Patient", "Doctor", "Receptionist" };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void R_PersonnelSearch_Load(object sender, EventArgs e)
        {

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
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.SelectPersonnel((string)TypeComboBox.SelectedValue, Convert.ToInt32(NameComboBox.SelectedValue));
            resultDataGridView.DataSource = dt3;
            resultDataGridView.Refresh();
        }
    }
}
