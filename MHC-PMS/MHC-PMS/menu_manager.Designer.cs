namespace MHC_PMS
{
    partial class menu_manager
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
            this.listBox_reports = new System.Windows.Forms.ListBox();
            this.textBox_report = new System.Windows.Forms.TextBox();
            this.button_viewReport = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // listBox_reports
            // 
            this.listBox_reports.FormattingEnabled = true;
            this.listBox_reports.ItemHeight = 16;
            this.listBox_reports.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April"});
            this.listBox_reports.Location = new System.Drawing.Point(13, 34);
            this.listBox_reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_reports.Name = "listBox_reports";
            this.listBox_reports.Size = new System.Drawing.Size(231, 420);
            this.listBox_reports.TabIndex = 1;
            // 
            // textBox_report
            // 
            this.textBox_report.Location = new System.Drawing.Point(251, 34);
            this.textBox_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_report.Multiline = true;
            this.textBox_report.Name = "textBox_report";
            this.textBox_report.Size = new System.Drawing.Size(671, 420);
            this.textBox_report.TabIndex = 2;
            // 
            // button_viewReport
            // 
            this.button_viewReport.Location = new System.Drawing.Point(12, 462);
            this.button_viewReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_viewReport.Name = "button_viewReport";
            this.button_viewReport.Size = new System.Drawing.Size(120, 30);
            this.button_viewReport.TabIndex = 3;
            this.button_viewReport.Text = "View Report";
            this.button_viewReport.UseVisualStyleBackColor = true;
            this.button_viewReport.Click += new System.EventHandler(this.button_viewReport_Click);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(800, 462);
            this.button_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(120, 30);
            this.button_print.TabIndex = 4;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report Details";
            // 
            // menu_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_viewReport);
            this.Controls.Add(this.textBox_report);
            this.Controls.Add(this.listBox_reports);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu_manager";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_manager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_reports;
        private System.Windows.Forms.TextBox textBox_report;
        private System.Windows.Forms.Button button_viewReport;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label2;
    }
}