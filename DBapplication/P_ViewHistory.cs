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
    public partial class P_ViewHistory : Form
    {
        private long _pid;
        private Controller controllerObj;

        public P_ViewHistory(long pid)
        {
            InitializeComponent();
            this._pid = pid;
            controllerObj = new Controller(); // Create the Controler Object


            TypeComboBox.DataSource = new string[] { "Medications", "Scans", "Diagnosis/Comments" };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ViewHistButton_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ViewPatientHistory((int)_pid, (string)TypeComboBox.SelectedValue);
            HistoryDataGridView.DataSource = dt1;
            HistoryDataGridView.Refresh();
        }
    }
}
