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
    public partial class P_ChangeRoom : Form
    {
        private Controller controllerObj = new Controller();
        private long _pid;

        public P_ChangeRoom(long pid)
        {
            InitializeComponent();
            this._pid = pid;
            curr_type.Text = controllerObj.GetRoomTypeFromPatientID(_pid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new PatientServices((long)_pid).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void ChnageRoom_Click(object sender, EventArgs e)
        {
            DataTable RoomsID = controllerObj.GetRoomsIDsOfCertainType(curr_type.Text);
            int freeRoomID = controllerObj.CheckRoomChangeAbility(RoomsID, controllerObj.GetReservedTimeSlotFromRegisterationByPatientID(_pid));
            if(freeRoomID>0)
            {
                long regID = controllerObj.selectRegistrationIDFromPatientID(_pid);
                int Result = controllerObj.ChangeRoom(freeRoomID, regID);
               // MessageBox.Show(Result.ToString());
                if(Result>0)
                {
                    
                    MessageBox.Show("Room Changed to room "+ freeRoomID + "");
                }
                else
                {
                    MessageBox.Show("An error occured While Changing Rooms");
                }
            }
            else
            {
                MessageBox.Show("sorry There is not an available room ");
            }
        }
    }
}
