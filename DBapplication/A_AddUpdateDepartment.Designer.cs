namespace DBapplication
{
    partial class A_AddUpdateDepartment
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
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.choose_dep_button = new System.Windows.Forms.Button();
            this.DepartmentsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(82, 246);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(171, 28);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(82, 192);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(171, 28);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Department";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(297, 192);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(171, 28);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Department";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(297, 114);
            this.DepartmentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.DepartmentNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department Name:";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(297, 246);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(171, 28);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // choose_dep_button
            // 
            this.choose_dep_button.Location = new System.Drawing.Point(58, 36);
            this.choose_dep_button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_dep_button.Name = "choose_dep_button";
            this.choose_dep_button.Size = new System.Drawing.Size(233, 28);
            this.choose_dep_button.TabIndex = 10;
            this.choose_dep_button.Text = "Choose a Department To Update:";
            this.choose_dep_button.UseVisualStyleBackColor = true;
            this.choose_dep_button.Click += new System.EventHandler(this.choose_dep_button_Click);
            // 
            // DepartmentsComboBox
            // 
            this.DepartmentsComboBox.FormattingEnabled = true;
            this.DepartmentsComboBox.Location = new System.Drawing.Point(340, 39);
            this.DepartmentsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentsComboBox.Name = "DepartmentsComboBox";
            this.DepartmentsComboBox.Size = new System.Drawing.Size(160, 24);
            this.DepartmentsComboBox.TabIndex = 11;
            // 
            // A_AddUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 334);
            this.Controls.Add(this.DepartmentsComboBox);
            this.Controls.Add(this.choose_dep_button);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmentNameTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_AddUpdateDepartment";
            this.Text = "A_AddUpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox DepartmentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button choose_dep_button;
        private System.Windows.Forms.ComboBox DepartmentsComboBox;
    }
}