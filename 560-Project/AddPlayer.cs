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
    public partial class AddPlayer : Form
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public string JerseyNumber { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = firstTextbox.Text;
            TeamName = secondTextbox.Text;
            JerseyNumber = thirdTextbox.Text;
            Height = fourthTextbox.Text;
            Weight = fifthTextbox.Text;
            Age = sixthTextbox.Text;
            this.Close();
        }
    }
}
