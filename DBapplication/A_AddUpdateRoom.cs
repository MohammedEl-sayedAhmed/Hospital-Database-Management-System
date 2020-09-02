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
    public partial class A_AddUpdateRoom : Form
    {
        private long _aid;
        Controller controllerObj;

        public A_AddUpdateRoom(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectRoomIDs();
            RoomsComboBox.DataSource = dt1;
            RoomsComboBox.DisplayMember = "RID";
            RoomsComboBox.ValueMember = "RID";

            RoomTypeComboBox.DataSource = new string[] { "Examination Room", "Surgery Room", "ICU" };

            DataTable dt2 = controllerObj.SelectDepIDsNames();
            depComboBox.DataSource = dt2;
            depComboBox.DisplayMember = "Name";
            depComboBox.ValueMember = "DepID";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void A_AddUpdateRoom_Load(object sender, EventArgs e)
        {

        }

        private void RoomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoomSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void choose_room_button_Click(object sender, EventArgs e)
        {
            DataRow Room = controllerObj.SelectRoom(Convert.ToInt32(RoomsComboBox.SelectedValue)).Rows[0];

            RoomTypeComboBox.SelectedItem = Room["Type"];
            RoomSizeTextBox.Text = Convert.ToString(Room["Size"]);
            RoomPriceTextBox.Text = Convert.ToString(Room["Price"]);
            depComboBox.SelectedValue = Room["Department_ID"];
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            if (RoomPriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the room type, price and associated department.");
            }
            else
            {
                int r = controllerObj.A_AddRoom((string)RoomTypeComboBox.SelectedItem,
                    RoomSizeTextBox.Text.ToString(),
                    Convert.ToInt32(RoomPriceTextBox.Text.ToString()),
                    (int)depComboBox.SelectedValue);

                if (r > 0)
                {
                    MessageBox.Show("Room added successfully.");

                    DataTable dt1 = controllerObj.SelectRoomIDs();
                    RoomsComboBox.DataSource = dt1;
                    RoomsComboBox.DisplayMember = "RID";
                    RoomsComboBox.ValueMember = "RID";
                }
                else
                {
                    MessageBox.Show("Error in adding room.");
                }
            }
        }

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {
            if (RoomPriceTextBox.Text == "")
            {
                MessageBox.Show("Please, enter at least the room type, price and associated department.");
            }
            else
            {
                int r = controllerObj.A_UpdateRoom(Convert.ToInt32(RoomsComboBox.SelectedValue),
                    (string)RoomTypeComboBox.SelectedItem,
                    RoomSizeTextBox.Text.ToString(),
                    Convert.ToInt32(RoomPriceTextBox.Text.ToString()),
                    (int)depComboBox.SelectedValue);

                if (r > 0)
                {
                    MessageBox.Show("Room updated successfully.");

                    DataTable dt1 = controllerObj.SelectRoomIDs();
                    RoomsComboBox.DataSource = dt1;
                    RoomsComboBox.DisplayMember = "RID";
                    RoomsComboBox.ValueMember = "RID";
                }
                else
                {
                    MessageBox.Show("Error in updating room.");
                }
            }
        }
    }
}
