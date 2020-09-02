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
    public partial class A_AddUpdateScan : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateScan(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectScanIDsNames();
            ScansComboBox.DataSource = dt1;
            ScansComboBox.DisplayMember = "Name";
            ScansComboBox.ValueMember = "SID";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void choose_scan_button_Click(object sender, EventArgs e)
        {
            DataRow Scan = controllerObj.SelectScan(Convert.ToInt32(ScansComboBox.SelectedValue)).Rows[0];

            NameTextBox.Text = Convert.ToString(Scan["Name"]);
            PriceTextBox.Text = Convert.ToString(Scan["Price"]);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the scan name and price.");
            }
            else
            {
                int r = controllerObj.A_AddScan(NameTextBox.Text.ToString(),
                    Convert.ToInt32(PriceTextBox.Text.ToString()));

                if (r > 0)
                {
                    MessageBox.Show("Scan added successfully.");

                    DataTable dt1 = controllerObj.SelectScanIDsNames();
                    ScansComboBox.DataSource = dt1;
                    ScansComboBox.DisplayMember = "Name";
                    ScansComboBox.ValueMember = "SID";
                }
                else
                {
                    MessageBox.Show("Error in adding scan.");
                }
            }
        }

        private void UpdateScanButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the scan name and price.");
            }
            else
            {
                int r = controllerObj.A_UpdateScan(Convert.ToInt32(ScansComboBox.SelectedValue),
                    ScansComboBox.Text.ToString(),
                    Convert.ToInt32(PriceTextBox.Text.ToString()));

                if (r > 0)
                {
                    MessageBox.Show("Scan updated successfully.");

                    DataTable dt1 = controllerObj.SelectScanIDsNames();
                    ScansComboBox.DataSource = dt1;
                    ScansComboBox.DisplayMember = "Name";
                    ScansComboBox.ValueMember = "SID";
                }
                else
                {
                    MessageBox.Show("Error in updating scan.");
                }
            }
        }
    }
}
