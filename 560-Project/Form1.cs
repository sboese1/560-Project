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
        //private string conn = "Data Source=(LocalDb)\\MSSQLLocalDb;Initial Catalog=Local;Persist Security Info=True;";
        private Dictionary<string, int> TeamInfo = new Dictionary<string, int>();

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
            SqlCommand cmd = new SqlCommand("SELECT TeamName, TeamID FROM dbo.Team", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TeamInfo.Add(reader.GetValue(0).ToString(), Convert.ToInt32(reader.GetValue(1)));
                string output = reader.GetValue(0).ToString();
                listBox1.Items.Add(output);
            }
            listBox1.SelectedIndex = 0;
            //connection.Close();
        }

        private void ViewTeamStatsButton_Click(object sender, EventArgs e)
        {
            SetTeamName = listBox1.SelectedItem.ToString();
        }

        private void standingsButton_Click(object sender, EventArgs e)
        {
            string tempFirst = firstDateTB.Text;
            string tempLast = lastDateTB.Text;
            if (tempFirst == "" || tempLast == "")
            {
                MessageBox.Show("Both First Date and Last Date text boxes need to be entered!");
                return;
            }

            string firstDate = CheckDate(tempFirst);
            string lastDate = CheckDate(tempLast);
            if (firstDate == null || lastDate == null) return;

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand("CalculateStandings", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@FirstDate", firstDate));
                    command.Parameters.Add(new SqlParameter("@LastDate", lastDate));

                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        listView1.Clear();
                        listView1.View = View.Details;
                        listView1.Columns.Add("Team");
                        listView1.Columns.Add("Wins");
                        listView1.Columns.Add("Losses");
                        listView1.Columns.Add("Standing");
                        while (sdr.Read())
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { sdr["TeamName"].ToString(),
                                sdr["WinningTotal"].ToString(), sdr["LosingTotal"].ToString(), sdr["Standing"].ToString() }));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void playerAveragesButton_Click(object sender, EventArgs e)
        {
            string tempFirst = firstDateTB.Text;
            string tempLast = lastDateTB.Text;
            if (tempFirst == "" || tempLast == "")
            {
                MessageBox.Show("Both First Date and Last Date text boxes need to be entered!");
                return;
            }

            string firstDate = CheckDate(tempFirst);
            string lastDate = CheckDate(tempLast);
            if (firstDate == null || lastDate == null) return;

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand("CalculatePlayerAverages", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@FirstDate", firstDate));
                    command.Parameters.Add(new SqlParameter("@LastDate", lastDate));

                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        listView1.Clear();
                        listView1.View = View.Details;
                        listView1.Columns.Add("Name");
                        listView1.Columns.Add("PPG");
                        listView1.Columns.Add("REB");
                        listView1.Columns.Add("AST");
                        listView1.Columns.Add("Points Ranking");
                        listView1.Columns.Add("Rebounds Ranking");
                        listView1.Columns.Add("Assists Ranking");
                        while (sdr.Read())
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { sdr["Name"].ToString(),
                                sdr["PPG"].ToString(), sdr["REB"].ToString(), sdr["AST"].ToString(),
                                sdr["PointsRanking"].ToString(), sdr["ReboundsRanking"].ToString(), 
                                sdr["AssistsRanking"].ToString()}));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void dayPointTotalsButton_Click(object sender, EventArgs e)
        {
            string temp = firstDateTB.Text;
            if (temp == "" && lastDateTB.Text != "") temp = lastDateTB.Text;
            if (firstDateTB.Text == "" && lastDateTB.Text == "")
            {
                MessageBox.Show("At least one of First Date and Last Date text boxes need to be entered!");
                return;
            }

            string date = CheckDate(temp);
            if (date == null) return;

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand("CalculateDayPointTotals", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@Date", date));

                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        listView1.Clear();
                        listView1.View = View.Details;
                        listView1.Columns.Add("PPG");
                        listView1.Columns.Add("Highest");
                        listView1.Columns.Add("Lowest");
                        while (sdr.Read())
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { sdr["PPG"].ToString(),
                                sdr["Highest"].ToString(), sdr["Lowest"].ToString()}));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void playerTotalsButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand("CalculatePlayerTotals", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    string team = listBox1.SelectedItem.ToString();
                    int id = TeamInfo[team];
                    command.Parameters.Add(new SqlParameter("@TeamID", id));

                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        listView1.Clear();
                        listView1.View = View.Details;
                        listView1.Columns.Add("Name");
                        listView1.Columns.Add("TotalPoints");
                        listView1.Columns.Add("TotalRebounds");
                        listView1.Columns.Add("TotalAssists");
                        listView1.Columns.Add("GamesPlayed");
                        while (sdr.Read())
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { sdr["Name"].ToString(),
                                sdr["TotalPoints"].ToString(), sdr["TotalRebounds"].ToString(),
                                sdr["TotalAssists"].ToString(), sdr["GamesPlayed"].ToString()}));
                        }
                    }
                }
                connection.Close();
            }
        }

        private string CheckDate(string temp)
        {
            char firstSeperator;
            if (temp.Contains('/')) firstSeperator = '/';
            else if (temp.Contains('-')) firstSeperator = '-';
            else
            {
                MessageBox.Show("Incorrect date format. Needs to be YYYY-MM-DD");
                return null;
            }

            string[] pieces = temp.Split(firstSeperator);
            if (pieces.Length != 3)
            {
                MessageBox.Show("Incorrect date format. Needs to be YYYY-MM-DD");
                return null;
            }

            string result = pieces[0] + "-" + pieces[1] + "-" + pieces[2];
            for (int i = 0; i < pieces.Length; i++) if (pieces[i].Length == 1) pieces[i] = "0" + pieces[i];
            if (pieces[0].Length != 4 || pieces[1].Length != 2 || pieces[2].Length != 2)
            {
                if (pieces[0].Length == 2 && pieces[1].Length == 2 && pieces[2].Length == 4)
                    result = pieces[2] + "-" + pieces[0] + "-" + pieces[1];
                else
                {
                    MessageBox.Show("Incorrect date format. Needs to be YYYY-MM-DD");
                    return null;
                }
            }

            return result;
        }
    }
}
