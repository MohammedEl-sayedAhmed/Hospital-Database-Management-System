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
    public partial class A_ViewDoctorRatings : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_ViewDoctorRatings(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectDoctorIDsNames();
            DoctorRatingCombobox.DataSource = dt1;
            DoctorRatingCombobox.DisplayMember = "Name";
            DoctorRatingCombobox.ValueMember = "DID";

            DataTable dt2 = controllerObj.ViewAvgDrsRatings();
            avgRatingsDataGridView.DataSource = dt2;
            avgRatingsDataGridView.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_ViewDoctorRatings_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void logout_button_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void view_rate_btn_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.ViewDrRatings(Convert.ToInt32(DoctorRatingCombobox.SelectedValue));
            doctorRatingGridView.DataSource = dt3;
            doctorRatingGridView.Refresh();
        }
    }
}
