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
    public partial class menu_administrator : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        private static SqlDataReader reader;

        public menu_administrator()
        {
            InitializeComponent();
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            password = LogIn.computeSHA1fromString(password);
            string type = "";
            if (radio_manager.Checked) {
                type = "manager";
            } else if (radio_nurse.Checked) {
                type = "nurse";
            } else if (radio_receptionist.Checked) {
                type = "receptionist";
            }
            int facilityID = 0;
            command.CommandText = String.Format("select uniqueID from facilities where name='{0}'", comboBox_facilities.Text);
            reader = command.ExecuteReader();
            if (reader.HasRows){
                reader.Read();
                facilityID = Int32.Parse(reader[0].ToString());
            } else {
                reader.Close();
                command.CommandText = String.Format("insert into facilities (name) values ('{0}')",comboBox_facilities.Text);
                command.ExecuteNonQuery();
            }
            command = new SqlCommand(String.Format(
  @"IF NOT EXISTS 
    (SELECT  1
     FROM users 
     WHERE username = '{0}')
    BEGIN
     INSERT into users (username, password, memberOf, type)
     VALUES('{0}', '{1}', {2}, '{3})
    END; ", username, password, facilityID, type));
            reader.Close();
        }
    }
}
