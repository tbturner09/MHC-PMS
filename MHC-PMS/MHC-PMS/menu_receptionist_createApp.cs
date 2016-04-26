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
    public partial class menu_receptionist_createApp : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        private static SqlDataReader reader;
        private Boolean isOpen = false;
        public menu_receptionist_createApp()
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
            isOpen = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            close();
            open();
            if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_address.Text == "" || textBox_comments.Text == "")
            {
                MessageBox.Show("You must fill out all necessary fields!");
            } else
            {
                command.CommandText = String.Format("insert into patients (firstname,lastname,address,hazardous,birthday) values ('{0}','{1}','{2}',{3},'{4}')",
                                                        textBox_firstname.Text,textBox_lastname.Text,textBox_address.Text,Convert.ToInt32(checkBox_isHazardous.Checked),calendar_birthdate.Value);
                command.ExecuteNonQuery();
                close();
                open();
                command.CommandText = String.Format("select uniqueID from patients where firstname='{0}' and lastname='{1}' and birthday='{2}'", textBox_firstname.Text,textBox_lastname.Text,calendar_birthdate.Value);
                reader = command.ExecuteReader();
                reader.Read();
                string patientID = reader[0].ToString();
                close();
                open();
                command.CommandText = String.Format("insert into appointments (patientID,time,comments) values ('{0}','{1}','{2}')",patientID,calendar_appDate.Value,textBox_comments.Text);
                command.ExecuteNonQuery();
                close();
                this.Close();
            }
        }

        private void menu_receptionist_createApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
            this.Dispose();
        }
    }
}
