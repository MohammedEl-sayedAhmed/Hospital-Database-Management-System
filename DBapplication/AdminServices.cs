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
    public partial class AdminServices : Form
    {
        private long _aid;

        public AdminServices(long aid)
        {
            InitializeComponent();
            this._aid = aid;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void add_upd_admin_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateAdmin((long)_aid).Show();
            this.Close();
        }

        private void add_upd_dr_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateDoctor((long)_aid).Show();
            this.Close();
        }

        private void add_upd_recep_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateReceptionist((long)_aid).Show();
            this.Close();
        }

        private void add_upd_dep_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateDepartment((long)_aid).Show();
            this.Close();
        }

        private void add_upd_room_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateRoom((long)_aid).Show();
            this.Close();
        }

        private void add_upd_med_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateMedication((long)_aid).Show();
            this.Close();
        }

        private void add_upd_scan_button_Click(object sender, EventArgs e)
        {
            new A_AddUpdateScan((long)_aid).Show();
            this.Close();
        }

        private void view_pat_reg_button_Click(object sender, EventArgs e)
        {
            new A_ViewPatientRegistrations((long)_aid).Show();
            this.Close();
        }

        private void view_pres_med_button_Click(object sender, EventArgs e)
        {
            new A_ViewPrescribedMedications((long)_aid).Show();
            this.Close();
        }

        private void view_ord_scans_button_Click(object sender, EventArgs e)
        {
            new A_ViewOrderedScans((long)_aid).Show();
            this.Close();
        }

        private void view_dr_ratings_button_Click(object sender, EventArgs e)
        {
            new A_ViewDoctorRatings((long)_aid).Show();
            this.Close();
        }

        private void personnel_search_button_Click(object sender, EventArgs e)
        {
            new A_PersonnelSearch((long)_aid).Show();
            this.Close();
        }

        private void gen_stat_rep_button_Click(object sender, EventArgs e)
        {
            new ViewsAndStatisticsForm(_aid).Show();
            this.Close();
            //new A_GenerateStatisticalReports((long)_aid).Show();
            //this.Close();
        }

        private void upd_info_button_Click(object sender, EventArgs e)
        {
            new A_UpdateInfo((long)_aid).Show();
            this.Close();
        }

        private void ReportViewButton_Click(object sender, EventArgs e)
        {
            new ViewsAndStatisticsForm(_aid).Show();
            this.Close();
        }
    }
}
