namespace DBapplication
{
    partial class A_AddUpdateRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.UpdateRoomButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.RoomPriceTextBox = new System.Windows.Forms.TextBox();
            this.RoomSizeTextBox = new System.Windows.Forms.TextBox();
            this.RoomsComboBox = new System.Windows.Forms.ComboBox();
            this.RoomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.choose_room_button = new System.Windows.Forms.Button();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department Associated:";
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(98, 323);
            this.AddRoomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(116, 28);
            this.AddRoomButton.TabIndex = 6;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // UpdateRoomButton
            // 
            this.UpdateRoomButton.Location = new System.Drawing.Point(270, 323);
            this.UpdateRoomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateRoomButton.Name = "UpdateRoomButton";
            this.UpdateRoomButton.Size = new System.Drawing.Size(116, 28);
            this.UpdateRoomButton.TabIndex = 7;
            this.UpdateRoomButton.Text = "Update Room";
            this.UpdateRoomButton.UseVisualStyleBackColor = true;
            this.UpdateRoomButton.Click += new System.EventHandler(this.UpdateRoomButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(98, 378);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 28);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(270, 378);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(116, 28);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // RoomPriceTextBox
            // 
            this.RoomPriceTextBox.Location = new System.Drawing.Point(268, 203);
            this.RoomPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomPriceTextBox.Name = "RoomPriceTextBox";
            this.RoomPriceTextBox.Size = new System.Drawing.Size(156, 22);
            this.RoomPriceTextBox.TabIndex = 12;
            // 
            // RoomSizeTextBox
            // 
            this.RoomSizeTextBox.Location = new System.Drawing.Point(268, 155);
            this.RoomSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomSizeTextBox.Name = "RoomSizeTextBox";
            this.RoomSizeTextBox.Size = new System.Drawing.Size(156, 22);
            this.RoomSizeTextBox.TabIndex = 13;
            this.RoomSizeTextBox.TextChanged += new System.EventHandler(this.RoomSizeTextBox_TextChanged);
            // 
            // RoomsComboBox
            // 
            this.RoomsComboBox.FormattingEnabled = true;
            this.RoomsComboBox.Location = new System.Drawing.Point(277, 44);
            this.RoomsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomsComboBox.Name = "RoomsComboBox";
            this.RoomsComboBox.Size = new System.Drawing.Size(160, 24);
            this.RoomsComboBox.TabIndex = 16;
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.FormattingEnabled = true;
            this.RoomTypeComboBox.Items.AddRange(new object[] {
            "Examination Room",
            "Surgery Room",
            "ICU"});
            this.RoomTypeComboBox.Location = new System.Drawing.Point(268, 114);
            this.RoomTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.Size = new System.Drawing.Size(156, 24);
            this.RoomTypeComboBox.TabIndex = 17;
            this.RoomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomTypeComboBox_SelectedIndexChanged);
            // 
            // choose_room_button
            // 
            this.choose_room_button.Location = new System.Drawing.Point(37, 41);
            this.choose_room_button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_room_button.Name = "choose_room_button";
            this.choose_room_button.Size = new System.Drawing.Size(214, 28);
            this.choose_room_button.TabIndex = 18;
            this.choose_room_button.Text = "Choose A Room To Update:";
            this.choose_room_button.UseVisualStyleBackColor = true;
            this.choose_room_button.Click += new System.EventHandler(this.choose_room_button_Click);
            // 
            // depComboBox
            // 
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(268, 249);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(156, 24);
            this.depComboBox.TabIndex = 19;
            // 
            // A_AddUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 439);
            this.Controls.Add(this.depComboBox);
            this.Controls.Add(this.choose_room_button);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.RoomsComboBox);
            this.Controls.Add(this.RoomSizeTextBox);
            this.Controls.Add(this.RoomPriceTextBox);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateRoomButton);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A_AddUpdateRoom";
            this.Text = "A_AddUpdateRoom";
            this.Load += new System.EventHandler(this.A_AddUpdateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button UpdateRoomButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TextBox RoomPriceTextBox;
        private System.Windows.Forms.TextBox RoomSizeTextBox;
        private System.Windows.Forms.ComboBox RoomsComboBox;
        private System.Windows.Forms.ComboBox RoomTypeComboBox;
        private System.Windows.Forms.Button choose_room_button;
        private System.Windows.Forms.ComboBox depComboBox;
    }
}