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
    public partial class A_UpdateInfo : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_UpdateInfo(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            showInfo();
        }

        private void showInfo()
        {
            DataRow Admin = controllerObj.SelectAdmin((int)_aid).Rows[0];
            nameTextBox.Text = (string)Admin["Name"];
            usernameTextBox.Text = (string)Admin["Username"];
            passwordTextBox.Text = (string)Admin["Password"];
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

        private void upd_info_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please, insert all specified values.");
            }
            else
            {
                int r = controllerObj.A_UpdateAdmin(nameTextBox.Text.ToString(), usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), (int)_aid);

                if (r > 0)
                {
                    MessageBox.Show("Information updated successfully");
                }
                else
                {
                    MessageBox.Show("Error in updating information.");
                }
            }
        }
    }
}
