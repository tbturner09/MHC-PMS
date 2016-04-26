using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MHC_PMS
{
    public partial class menu_manager : Form
    {
        private static SqlConnection conn = new SqlConnection(LogIn.connectionString);
        private static SqlCommand command = new SqlCommand("", conn);
        private static SqlDataReader reader;
        public menu_manager()
        {
            InitializeComponent();
            conn.Open();
            menu_loadingDialog loader = new menu_loadingDialog();
            loader.Show();
            Thread.Sleep(5000);
            generateReports();
            loader.Dispose();
        }

        private void button_viewReport_Click(object sender, EventArgs e)
        {
            generateReports();
        }

        private void menu_manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            LogIn login = new LogIn();
            login.Show();
        }
        private void generateReports()
        {
            Random statistics = new Random();
            int costs = statistics.Next(100000, 800000);
            int newPatients = statistics.Next(10, 30);
            int leftPatients = statistics.Next(5, 20);
            int currentPatientNum = statistics.Next(30, 200) + newPatients;
            int atRiskPatients = statistics.Next(0, 10);
            command.CommandText = "SELECT TOP 8 name FROM medications ORDER BY NEWID()";
            reader = command.ExecuteReader();
            reader.Read();
            string firstMed = reader[0].ToString();
            reader.Read();
            string secondMed = reader[0].ToString();
            string otherMeds = "";
            for (int i = 0; i < 6;i++)
            {
                reader.Read();
                otherMeds += reader[0] + ", ";
            }
            fillTextbox(costs, newPatients, leftPatients, 
                        currentPatientNum, atRiskPatients, 
                        firstMed, secondMed,otherMeds);
            reader.Close();
        }
        private void fillTextbox(   int cost, 
                                    int newPatients, 
                                    int leftPatients, 
                                    int currentPatientNum, 
                                    int atRiskPatients, 
                                    string medMostPrescribed, 
                                    string medSecondPrescribed, 
                                    string otherMeds)
        {
            textBox_report.Text = String.Format(@"Report for: {0}
Current number of patients at facility: {1}
Number of at-risk/hazardous patients: {2}
Most prescribed medicine this month: {3}
Most prescribed medicine last month: {4}
Other medicines prescribed: {5}
Net cost of all expenses this month: {6}
Number of new patients this month: {7}
Number of patients that have left this month: {8}",
                            DateTime.Today,
                            currentPatientNum,
                            atRiskPatients,
                            medMostPrescribed,
                            medSecondPrescribed,
                            otherMeds,
                            cost,
                            newPatients,
                            leftPatients);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No printers found!");
        }
    }
}
