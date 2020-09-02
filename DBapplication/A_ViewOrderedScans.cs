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
    public partial class A_ViewOrderedScans : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_ViewOrderedScans(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.ViewOrderedScans();
            OrderedScansGridView.DataSource = dt1;
            OrderedScansGridView.Refresh();


            DataTable dt2 = controllerObj.SelectScanIDsNames();
            scansCombobox.DataSource = dt2;
            scansCombobox.DisplayMember = "Name";
            scansCombobox.ValueMember = "SID";
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

        private void view_scan_orders_btn_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.ViewScanOrders(Convert.ToInt32(scansCombobox.SelectedValue));
            oneScanDataGridView.DataSource = dt3;
            oneScanDataGridView.Refresh();
        }
    }
}
