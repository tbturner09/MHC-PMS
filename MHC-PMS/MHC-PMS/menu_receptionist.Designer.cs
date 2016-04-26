namespace MHC_PMS
{
    partial class menu_receptionist
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_appointments = new System.Windows.Forms.ListBox();
            this.button_deleteApp = new System.Windows.Forms.Button();
            this.button_createApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Week\'s Appointments";
            // 
            // listBox_appointments
            // 
            this.listBox_appointments.FormattingEnabled = true;
            this.listBox_appointments.ItemHeight = 16;
            this.listBox_appointments.Location = new System.Drawing.Point(13, 34);
            this.listBox_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_appointments.Name = "listBox_appointments";
            this.listBox_appointments.Size = new System.Drawing.Size(777, 452);
            this.listBox_appointments.TabIndex = 1;
            // 
            // button_deleteApp
            // 
            this.button_deleteApp.Location = new System.Drawing.Point(796, 444);
            this.button_deleteApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_deleteApp.Name = "button_deleteApp";
            this.button_deleteApp.Size = new System.Drawing.Size(120, 42);
            this.button_deleteApp.TabIndex = 4;
            this.button_deleteApp.Text = "Delete Appointment";
            this.button_deleteApp.UseVisualStyleBackColor = true;
            this.button_deleteApp.Click += new System.EventHandler(this.button_deleteApp_Click);
            // 
            // button_createApp
            // 
            this.button_createApp.Location = new System.Drawing.Point(797, 34);
            this.button_createApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_createApp.Name = "button_createApp";
            this.button_createApp.Size = new System.Drawing.Size(120, 42);
            this.button_createApp.TabIndex = 5;
            this.button_createApp.Text = "Create Appointment";
            this.button_createApp.UseVisualStyleBackColor = true;
            this.button_createApp.Click += new System.EventHandler(this.button_createApp_Click);
            // 
            // menu_receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.button_createApp);
            this.Controls.Add(this.button_deleteApp);
            this.Controls.Add(this.listBox_appointments);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu_receptionist";
            this.Text = "Receptionist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_receptionist_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_appointments;
        private System.Windows.Forms.Button button_deleteApp;
        private System.Windows.Forms.Button button_createApp;
    }
}