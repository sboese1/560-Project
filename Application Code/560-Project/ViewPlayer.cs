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
    public partial class ViewPlayer : Form
    {
        public string Name { get; set; }
        public string JerseyNumber { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }

        public ViewPlayer(string name, string num, string height, string weight, string age)
        {
            InitializeComponent();
            nameTB.Text = name;
            numTB.Text = num;
            heightTB.Text = height;
            weightTB.Text = weight;
            ageTB.Text = age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = nameTB.Text;
            JerseyNumber = numTB.Text;
            Height = heightTB.Text;
            Weight = weightTB.Text;
            Age = ageTB.Text;
            this.Close();
        }
    }
}
