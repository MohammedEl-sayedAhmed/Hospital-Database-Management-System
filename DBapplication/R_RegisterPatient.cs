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
    public partial class R_RegisterPatient : Form
    {
        private Controller controllerObj = new Controller();
        private long _recid;

        public R_RegisterPatient(long recid)
        {
            InitializeComponent();
            this._recid = recid;
            DataTable dt1 = controllerObj.SelectAllUnRelievedPatients();
            PatientComboBox.DataSource = dt1;
            PatientComboBox.DisplayMember = "Name";
            
            DataTable dt3 = controllerObj.SelectAllDoctors();
            DoctorComboBox.DataSource = dt3;
            DoctorComboBox.DisplayMember = "Name";
            RoomComboBox.Items.Add("Examination Room");
            RoomComboBox.Items.Add("ICU");
            RoomComboBox.Items.Add("Surgery Room");
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (controllerObj.DoctorFreeCheck(controllerObj.GetDoctorIDFromName(DoctorComboBox.Text),(int)ReservedNumericUpDown.Value,controllerObj.GetRoomsIDsOfCertainType(RoomComboBox.Text))!=0)
            {
                long RoomID = controllerObj.DoctorFreeCheck(controllerObj.GetDoctorIDFromName(DoctorComboBox.Text), (int)ReservedNumericUpDown.Value, controllerObj.GetRoomsIDsOfCertainType(RoomComboBox.Text));
                
              
                    int result = controllerObj.insertRegisteration(_recid, controllerObj.GetDoctorIDFromName(DoctorComboBox.Text), controllerObj.GetPatientIDFromName(PatientComboBox.Text), RoomID, (int)ReservedNumericUpDown.Value);
                    if (result>0)
                    {
                        MessageBox.Show("Reservation was successfull ");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, reservation failed.");
                    }
              
            }
            else
            {
                MessageBox.Show("Doctor  is not free at this time slot Or there might not be enough rooms.");
            }
        }
    }
}
