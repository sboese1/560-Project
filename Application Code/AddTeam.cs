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
    public partial class AddTeam : Form
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public AddTeam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = firstTextbox.Text;
            Color = secondTextbox.Text;
            this.Close();
        }
    }
}
