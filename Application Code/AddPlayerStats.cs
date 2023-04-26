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
    public partial class AddPlayerStats : Form
    {
        public string GameDate { get; set; }
        public string Points { get; set; }
        public string Rebounds { get; set; }
        public string Assists { get; set; }

        public AddPlayerStats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameDate = thirdTextbox.Text;
            Points = fourthTextbox.Text;
            Rebounds = fifthTextbox.Text;
            Assists = sixthTextbox.Text;
            this.Close();
        }
    }
}
