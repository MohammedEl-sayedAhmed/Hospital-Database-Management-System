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
    public partial class A_AddUpdateMedication : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateMedication(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectMedsIDsNames();
            MedicationsComboBox.DataSource = dt1;
            MedicationsComboBox.DisplayMember = "Name";
            MedicationsComboBox.ValueMember = "MID";
        }

        private void AddMedicationButton_Click(object sender, EventArgs e)
        {
            if (MedicationNameBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the medication name and price.");
            }
            else
            {
                int r = controllerObj.A_AddMedication(MedicationNameBox.Text.ToString(),
                    Convert.ToInt32(PriceTextBox.Text.ToString()),
                    (ExpiaryDateTimePicker.Value).ToString("yyyy-MM-dd"));

                if (r > 0)
                {
                    MessageBox.Show("Medication added successfully.");

                    DataTable dt1 = controllerObj.SelectMedsIDsNames();
                    MedicationsComboBox.DataSource = dt1;
                    MedicationsComboBox.DisplayMember = "Name";
                    MedicationsComboBox.ValueMember = "MID";
                }
                else
                {
                    MessageBox.Show("Error in adding medication.");
                }
            }
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


        private void A_AddUpdateMedication_Load(object sender, EventArgs e)
        {

        }

        private void UpdateMedicationButton_Click(object sender, EventArgs e)
        {
            if (MedicationNameBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the medication name and price.");
            }
            else
            {
                int r = controllerObj.A_UpdateMedication(Convert.ToInt32(MedicationsComboBox.SelectedValue),
                    MedicationNameBox.Text.ToString(),
                    Convert.ToInt32(PriceTextBox.Text.ToString()),
                    (ExpiaryDateTimePicker.Value).ToString("yyyy-MM-dd"));

                if (r > 0)
                {
                    MessageBox.Show("Medication updated successfully.");

                    DataTable dt1 = controllerObj.SelectMedsIDsNames();
                    MedicationsComboBox.DataSource = dt1;
                    MedicationsComboBox.DisplayMember = "Name";
                    MedicationsComboBox.ValueMember = "MID";
                }
                else
                {
                    MessageBox.Show("Error in updating medication.");
                }
            }
        }

        private void choose_med_button_Click(object sender, EventArgs e)
        {
            DataRow Med = controllerObj.SelectMedication(Convert.ToInt32(MedicationsComboBox.SelectedValue)).Rows[0];

            MedicationNameBox.Text = Convert.ToString(Med["Name"]);
            PriceTextBox.Text = Convert.ToString(Med["Price"]);
            ExpiaryDateTimePicker.Value = (DateTime)Med["Exp_Date"];
        }
    }
}
