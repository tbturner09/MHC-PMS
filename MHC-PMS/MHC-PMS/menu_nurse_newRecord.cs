using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MHC_PMS
{
    public partial class menu_nurse_newRecord : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        public static string patientID;
        private Boolean isOpen = false;
        public menu_nurse_newRecord()
        {
            InitializeComponent();
            open();
        }

        private void open()
        {
            if (!isOpen)
            {
                conn.ConnectionString = LogIn.connectionString;
                conn.Open();
                isOpen = true;
            }
        }
        private void close()
        {
            command.Dispose();
            conn.Close();
            conn.Dispose();
        }
        private void menu_nurse_newRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
            this.Dispose();
        }

        
        private void button_submitReport_Click(object sender, EventArgs e)
        {
            open();
            command.CommandText = String.Format("insert into patientdata (recorddate,notes,medications,patientID) values ('{0}','{1}','{2}','{3}')",
                                        DateTime.Now,textBox_notes.Text,textBox_medications.Text,patientID);
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
