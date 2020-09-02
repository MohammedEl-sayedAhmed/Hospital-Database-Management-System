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
    public partial class PatientServices : Form
    {

        private long _pid;

        public PatientServices(long pid)
        {
            InitializeComponent();
            this._pid = pid;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void view_bills_button_Click(object sender, EventArgs e)
        {
            new P_ViewBills((long)_pid).Show();
            this.Close();
        }

        private void view_history_button_Click(object sender, EventArgs e)
        {
            new P_ViewHistory((long)_pid).Show();
            this.Close();
        }

        private void change_room_button_Click(object sender, EventArgs e)
        {
            new P_ChangeRoom((long)_pid).Show();
            this.Close();
        }

        private void rate_doctor_button_Click(object sender, EventArgs e)
        {
            new P_RateDoctor((long)_pid).Show();
            this.Close();
        }

        private void update_info_button_Click(object sender, EventArgs e)
        {
            new P_UpdateInfo((long)_pid).Show();
            this.Close();
        }
    }
}
