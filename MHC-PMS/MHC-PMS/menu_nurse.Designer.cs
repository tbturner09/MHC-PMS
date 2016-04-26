namespace MHC_PMS
{
    partial class menu_nurse
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
            this.listBox_records = new System.Windows.Forms.ListBox();
            this.textBox_record = new System.Windows.Forms.TextBox();
            this.comboBox_patients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_newRecord = new System.Windows.Forms.Button();
            this.button_viewReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_records
            // 
            this.listBox_records.FormattingEnabled = true;
            this.listBox_records.Location = new System.Drawing.Point(10, 50);
            this.listBox_records.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_records.Name = "listBox_records";
            this.listBox_records.Size = new System.Drawing.Size(226, 316);
            this.listBox_records.TabIndex = 0;
            // 
            // textBox_record
            // 
            this.textBox_record.Location = new System.Drawing.Point(240, 11);
            this.textBox_record.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_record.Multiline = true;
            this.textBox_record.Name = "textBox_record";
            this.textBox_record.Size = new System.Drawing.Size(451, 387);
            this.textBox_record.TabIndex = 1;
            // 
            // comboBox_patients
            // 
            this.comboBox_patients.FormattingEnabled = true;
            this.comboBox_patients.Location = new System.Drawing.Point(9, 27);
            this.comboBox_patients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_patients.Name = "comboBox_patients";
            this.comboBox_patients.Size = new System.Drawing.Size(227, 21);
            this.comboBox_patients.TabIndex = 2;
            this.comboBox_patients.SelectedValueChanged += new System.EventHandler(this.comboBox_patients_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // button_newRecord
            // 
            this.button_newRecord.Location = new System.Drawing.Point(146, 375);
            this.button_newRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_newRecord.Name = "button_newRecord";
            this.button_newRecord.Size = new System.Drawing.Size(90, 24);
            this.button_newRecord.TabIndex = 4;
            this.button_newRecord.Text = "New Record";
            this.button_newRecord.UseVisualStyleBackColor = true;
            this.button_newRecord.Click += new System.EventHandler(this.button_newRecord_Click);
            // 
            // button_viewReport
            // 
            this.button_viewReport.Location = new System.Drawing.Point(9, 375);
            this.button_viewReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_viewReport.Name = "button_viewReport";
            this.button_viewReport.Size = new System.Drawing.Size(90, 24);
            this.button_viewReport.TabIndex = 6;
            this.button_viewReport.Text = "View Record";
            this.button_viewReport.UseVisualStyleBackColor = true;
            this.button_viewReport.Click += new System.EventHandler(this.button_viewReport_Click);
            // 
            // menu_nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.button_viewReport);
            this.Controls.Add(this.button_newRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_patients);
            this.Controls.Add(this.textBox_record);
            this.Controls.Add(this.listBox_records);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menu_nurse";
            this.Text = "Nurse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_nurse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_records;
        private System.Windows.Forms.TextBox textBox_record;
        private System.Windows.Forms.ComboBox comboBox_patients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_newRecord;
        private System.Windows.Forms.Button button_viewReport;
    }
}