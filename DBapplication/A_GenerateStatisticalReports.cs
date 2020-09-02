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
    public partial class A_GenerateStatisticalReports : Form
    {
        private long _aid;

        public A_GenerateStatisticalReports(long aid)
        {
            InitializeComponent();
            this._aid = aid;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }
    }
}
