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

namespace _560_Project
{
    public partial class Form1 : Form
    {
        private string conn = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cjbrown1;Persist Security Info=True;User ID=cjbrown1;Password=SheropTrogOui24";

        public static string SetTeamName;
        public static string SetPlayerName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ViewPlayerStatsButton_Click(object sender, EventArgs e)
        {
            SetPlayerName = listBox2.SelectedItem.ToString();
            PlayerStats p = new PlayerStats();
            p.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Player as p join dbo.Team as t on p.TeamID = t.TeamID WHERE t.TeamName = '" + listBox1.SelectedItem.ToString() + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string output = reader.GetValue(0).ToString();
                listBox2.Items.Add(output);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewTeamButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TeamName FROM dbo.Team", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string output = reader.GetValue(0).ToString();
                listBox1.Items.Add(output);
            }
            //connection.Close();
        }

        private void ViewTeamStatsButton_Click(object sender, EventArgs e)
        {
            SetTeamName = listBox1.SelectedItem.ToString();
        }
    }
}
