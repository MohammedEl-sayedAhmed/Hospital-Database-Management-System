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
    public partial class ReceptionistServices : Form
    {

        private long _recid;


        public ReceptionistServices(long recid)
        {
            InitializeComponent();
            this._recid = recid;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void add_upd_pat_button_Click(object sender, EventArgs e)
        {
            new R_AddUpdatePatient((long)_recid).Show();
            this.Close();
        }

        private void register_pat_button_Click(object sender, EventArgs e)
        {
            new R_RegisterPatient((long)_recid).Show();
            this.Close();
        }

        private void personnel_search_button_Click(object sender, EventArgs e)
        {
            new R_PersonnelSearch((long)_recid).Show();
            this.Close();
        }

        private void update_info_button_Click(object sender, EventArgs e)
        {
            new R_UpdateInfo((long)_recid).Show();
            this.Close();
        }
    }
}
