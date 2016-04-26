namespace MHC_PMS
{
    partial class menu_nurse_newRecord
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
            this.textBox_medications = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.button_submitReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_medications
            // 
            this.textBox_medications.Location = new System.Drawing.Point(12, 29);
            this.textBox_medications.Name = "textBox_medications";
            this.textBox_medications.Size = new System.Drawing.Size(585, 20);
            this.textBox_medications.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes";
            // 
            // textBox_notes
            // 
            this.textBox_notes.Location = new System.Drawing.Point(12, 68);
            this.textBox_notes.Multiline = true;
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(675, 329);
            this.textBox_notes.TabIndex = 3;
            // 
            // button_submitReport
            // 
            this.button_submitReport.Location = new System.Drawing.Point(603, 27);
            this.button_submitReport.Name = "button_submitReport";
            this.button_submitReport.Size = new System.Drawing.Size(84, 23);
            this.button_submitReport.TabIndex = 4;
            this.button_submitReport.Text = "Submit Report";
            this.button_submitReport.UseVisualStyleBackColor = true;
            this.button_submitReport.Click += new System.EventHandler(this.button_submitReport_Click);
            // 
            // menu_nurse_newRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.button_submitReport);
            this.Controls.Add(this.textBox_notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_medications);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menu_nurse_newRecord";
            this.Text = "menu_nurse_newRecord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_nurse_newRecord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_medications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.Button button_submitReport;
    }
}