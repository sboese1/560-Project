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
    public partial class PlayerStats : Form
    {
        private string conn = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cjbrown1;Persist Security Info=True;User ID=cjbrown1;Password=SheropTrogOui24";
        //private string conn = "Data Source=(LocalDb)\\MSSQLLocalDb;Initial Catalog=Local;Persist Security Info=True;";


        public PlayerStats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerStats_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetPlayerName;
            label2.Text = Form1.SetTeamName;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT JerseyNumber FROM dbo.Player WHERE Name = '" + Form1.SetPlayerName + "'", connection);
            SqlCommand cmd2 = new SqlCommand("SELECT Height FROM dbo.Player WHERE Name = '" + Form1.SetPlayerName + "'", connection);
            SqlCommand cmd3 = new SqlCommand("SELECT Weight FROM dbo.Player WHERE Name = '" + Form1.SetPlayerName + "'", connection);
            SqlCommand cmd4 = new SqlCommand("SELECT Age FROM dbo.Player WHERE Name = '" + Form1.SetPlayerName + "'", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read(); 
            label3.Text = reader.GetValue(0).ToString();
            reader.Close();

            reader = cmd2.ExecuteReader();
            reader.Read();
            label4.Text = reader.GetValue(0).ToString();
            reader.Close();

            reader = cmd3.ExecuteReader();
            reader.Read();
            label5.Text = reader.GetValue(0).ToString();
            reader.Close();

            reader = cmd4.ExecuteReader();
            reader.Read();
            label6.Text = reader.GetValue(0).ToString();
            reader.Close();


        }
    }
}
