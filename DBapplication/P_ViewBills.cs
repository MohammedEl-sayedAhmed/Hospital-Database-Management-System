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
    public partial class P_ViewBills : Form
    {
        private long _pid;
        Controller controllerObj;

        public P_ViewBills(long pid)
        {
            InitializeComponent();
            this._pid = pid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.ViewPatientBills((int)_pid);
            BillsDataGridView.DataSource = dt1;
            BillsDataGridView.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new PatientServices((long)_pid).Show();
            this.Close();
        }
    }
}
