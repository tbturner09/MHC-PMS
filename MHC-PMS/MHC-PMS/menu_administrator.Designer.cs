namespace MHC_PMS
{
    partial class menu_administrator
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.radio_manager = new System.Windows.Forms.RadioButton();
            this.radio_nurse = new System.Windows.Forms.RadioButton();
            this.radio_receptionist = new System.Windows.Forms.RadioButton();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_facilities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(13, 37);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(199, 22);
            this.textBox_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(220, 37);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(199, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // radio_manager
            // 
            this.radio_manager.AutoSize = true;
            this.radio_manager.Location = new System.Drawing.Point(21, 70);
            this.radio_manager.Margin = new System.Windows.Forms.Padding(4);
            this.radio_manager.Name = "radio_manager";
            this.radio_manager.Size = new System.Drawing.Size(85, 21);
            this.radio_manager.TabIndex = 4;
            this.radio_manager.TabStop = true;
            this.radio_manager.Text = "Manager";
            this.radio_manager.UseVisualStyleBackColor = true;
            // 
            // radio_nurse
            // 
            this.radio_nurse.AutoSize = true;
            this.radio_nurse.Location = new System.Drawing.Point(119, 70);
            this.radio_nurse.Margin = new System.Windows.Forms.Padding(4);
            this.radio_nurse.Name = "radio_nurse";
            this.radio_nurse.Size = new System.Drawing.Size(67, 21);
            this.radio_nurse.TabIndex = 5;
            this.radio_nurse.TabStop = true;
            this.radio_nurse.Text = "Nurse";
            this.radio_nurse.UseVisualStyleBackColor = true;
            // 
            // radio_receptionist
            // 
            this.radio_receptionist.AutoSize = true;
            this.radio_receptionist.Location = new System.Drawing.Point(197, 69);
            this.radio_receptionist.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receptionist.Name = "radio_receptionist";
            this.radio_receptionist.Size = new System.Drawing.Size(107, 21);
            this.radio_receptionist.TabIndex = 6;
            this.radio_receptionist.TabStop = true;
            this.radio_receptionist.Text = "Receptionist";
            this.radio_receptionist.UseVisualStyleBackColor = true;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(318, 115);
            this.button_AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(100, 28);
            this.button_AddUser.TabIndex = 7;
            this.button_AddUser.Text = "Add User";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Facility Name";
            // 
            // comboBox_facilities
            // 
            this.comboBox_facilities.FormattingEnabled = true;
            this.comboBox_facilities.Location = new System.Drawing.Point(12, 119);
            this.comboBox_facilities.Name = "comboBox_facilities";
            this.comboBox_facilities.Size = new System.Drawing.Size(200, 24);
            this.comboBox_facilities.TabIndex = 10;
            // 
            // menu_administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(431, 151);
            this.Controls.Add(this.comboBox_facilities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.radio_receptionist);
            this.Controls.Add(this.radio_nurse);
            this.Controls.Add(this.radio_manager);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu_administrator";
            this.Text = "menu_administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.RadioButton radio_manager;
        private System.Windows.Forms.RadioButton radio_nurse;
        private System.Windows.Forms.RadioButton radio_receptionist;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_facilities;
    }
}