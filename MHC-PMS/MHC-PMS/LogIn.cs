using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace MHC_PMS
{
    public partial class LogIn : Form
    {
        public static string connectionString = "Server=niu5y7sr40.database.windows.net;Database=mhcpms;User Id=azureuser;Password=@bcone23;";
        private static SqlConnection conn = new SqlConnection();
        private static SqlCommand command = new SqlCommand(null,conn);
        private static SqlDataReader reader;
        private Boolean isOpen = false;
        public LogIn()
        {
            InitializeComponent();
            conn.ConnectionString = connectionString;
            open();
        }

        public static string computeSHA1fromString(string password)
        {
            string plaintext = password;
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] barray = sha.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
            string encrypted = "";
            foreach (byte b in barray)
            {
                encrypted += b.ToString("x2");
            }
            return encrypted;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            open();
            string password = computeSHA1fromString(textbox_password.Text);
            command.Dispose();
            if (command.Connection ==null ) { System.Diagnostics.Debug.WriteLine("yes"); }
            command.CommandText = String.Format("select password,type,uniqueID from users where username='{0}'", textbox_username.Text);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows) {
                if (password.Equals(reader[0]))
                {
                    switch (reader[1].ToString())
                    {
                        case "admin":
                            menu_administrator admin = new menu_administrator();
                            admin.Show();
                            //this.Hide();
                            close();
                            break;
                        case "manager":
                            menu_manager manager = new menu_manager();
                            manager.Show();
                            this.Hide();
                            close();
                            break;
                        case "nurse":
                            menu_nurse.id = reader[2].ToString();
                            menu_nurse nurse = new menu_nurse();
                            nurse.Show();
                            this.Hide();
                            close();
                            break;
                        case "receptionist":
                            menu_receptionist recp = new menu_receptionist();
                            recp.Show();
                            this.Hide();
                            close();
                            break;
                    }
                } else {
                    MessageBox.Show("Invalid Password");
                }
            } else {
                MessageBox.Show("Invalid Username");
            }
            close();
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
            reader.Close();
            command.Dispose();
            conn.Close();
            conn.Dispose();
            isOpen = false;
        }

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}