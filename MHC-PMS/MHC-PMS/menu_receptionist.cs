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
    public partial class menu_receptionist : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        private static SqlDataReader reader;
        private Boolean isOpen = false;
        public menu_receptionist()
        {
            InitializeComponent();
            open();
            loadAppts();
        }

        private void button_createApp_Click(object sender, EventArgs e)
        {
            menu_receptionist_createApp app = new menu_receptionist_createApp();
            app.Show();
            loadAppts();
        }

        private void menu_receptionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            LogIn login = new LogIn();
            login.Show();
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
        private void loadAppts()
        {
            close();
            open();
            command.CommandText = "select time,patientID,uniqueID from appointments where [time] >= current_timestamp and [time] < current_timestamp +7";
            reader = command.ExecuteReader();
            List<string> appts = new List<string>();
            while (reader.Read())
            {
                appts.Add(String.Format("Date: {0} - PatientID: {1} - UniqueID: {2}", reader[0].ToString(), reader[1].ToString(),reader[2].ToString()));
            }
            listBox_appointments.DataSource = appts;
            close();
        }

        private void button_deleteApp_Click(object sender, EventArgs e)
        {
            close();
            open();
            command.CommandText = String.Format("delete from appointments where uniqueID = '{0}'",
                                                    listBox_appointments.SelectedValue.ToString().Split(':')[5].Trim());
            command.ExecuteNonQuery();
            close();
            loadAppts();
        }
    }
}
