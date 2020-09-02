using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
   
    public partial class Login : Form
    {
        
        private Controller controllerObj; // A Reference of type Controller 
                                          // (Initially NULL; NO Controller Object is created yet)

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller(); // Create the Controler Object

            loginAsComboBox.DataSource = new string[] { "Patient", "Doctor", "Receptionist", "Admin" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click_1(object sender, EventArgs e)
        {
            if ((string)loginAsComboBox.SelectedValue == "Patient")
            {
                long id = controllerObj.PatientPasswordCheck(TxtBx_username.Text, TxtBx_pass.Text);

                if (id > 0)
                {
                    new PatientServices((long)id).Show();
                    TxtBx_pass.Clear();
                    TxtBx_username.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials. Please try again.");
                }
            }
            else if ((string)loginAsComboBox.SelectedValue == "Doctor")
            {
                long id = controllerObj.DoctorPasswordCheck(TxtBx_username.Text, TxtBx_pass.Text);

                if (id > 0)
                {
                    new DoctorServices((long)id).Show();
                    TxtBx_pass.Clear();
                    TxtBx_username.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials. Please try again.");
                }
            }
            else if ((string)loginAsComboBox.SelectedValue == "Receptionist")
            {
                long id = controllerObj.ReceptionistPasswordCheck(TxtBx_username.Text, TxtBx_pass.Text);

                if (id > 0)
                {
                    new ReceptionistServices((long)id).Show();
                    TxtBx_pass.Clear();
                    TxtBx_username.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials. Please try again.");
                }
            }
            else if((string)loginAsComboBox.SelectedValue == "Admin")
            {
                long id = controllerObj.AdminPasswordCheck(TxtBx_username.Text, TxtBx_pass.Text);

                if (id > 0)
                {
                    new AdminServices((long)id).Show();
                    TxtBx_pass.Clear();
                    TxtBx_username.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials. Please try again.");
                }
            }
        }
    }
}
