using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560_Project
{
    public partial class ViewTeam : Form
    {
        public string TeamName { get; set; }
        public string TeamColor { get; set; }

        public ViewTeam(string name, string color)
        {
            InitializeComponent();
            teamNameTB.Text = name;
            teamColorTB.Text = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamName = teamNameTB.Text;
            TeamColor = teamColorTB.Text;
            this.Close();
        }
    }
}
