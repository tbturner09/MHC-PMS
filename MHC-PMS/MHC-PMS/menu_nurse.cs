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
using System.Collections;

namespace MHC_PMS
{
    public partial class menu_nurse : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        private static SqlDataReader reader;
        public static string id;
        public menu_nurse()
        {
            InitializeComponent();
            command.CommandText = "select firstname,lastname,uniqueID from patients where nurse=" + id + ";";
            conn.Open();
            reader = command.ExecuteReader();
            List<string> patients = new List<string>();
            while (reader.Read())
            {
                patients.Add(reader[0].ToString() + " " + reader[1].ToString() + ":" + reader[2].ToString());
            }
            comboBox_patients.DataSource = patients;
            close();
        }

        private void menu_nurse_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            LogIn login = new LogIn();
            login.Show();
        }

        private void close()
        {
            reader.Close();
            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        private void open()
        {
            conn.ConnectionString = LogIn.connectionString;
            conn.Open();
        }

        private void comboBox_patients_SelectedValueChanged(object sender, EventArgs e)
        {
            close();
            open();
            command.CommandText = "select recorddate,medications,notes from patientdata where patientID=" + comboBox_patients.SelectedValue.ToString().Split(':')[1];
            Dictionary<string, string[]> records = new Dictionary<string, string[]>();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                records.Add(reader[0].ToString(),new string[2] { reader[1].ToString(), reader[2].ToString() });
            }
            listBox_records.DataSource = new BindingSource(records, null);
            listBox_records.DisplayMember = "Value";
            listBox_records.ValueMember = "Key";
        }

        private void button_newRecord_Click(object sender, EventArgs e)
        {
            menu_nurse_newRecord.patientID = comboBox_patients.SelectedValue.ToString().Split(':')[1];
            menu_nurse_newRecord record = new menu_nurse_newRecord();
            record.ShowDialog();
            comboBox_patients_SelectedValueChanged(null, null);
        }

        private void button_viewReport_Click(object sender, EventArgs e)
        {
            string[] itemarr;
            try {
                itemarr = ((KeyValuePair<string, string[]>)listBox_records.SelectedItem).Value;
            } catch {
                textBox_record.Text = "No records for this patient yet.";
                return;
            }
            textBox_record.Text = String.Format(
@"Medications: {0}
Notes: {1}", itemarr[0],itemarr[1]);
        }
    }
}