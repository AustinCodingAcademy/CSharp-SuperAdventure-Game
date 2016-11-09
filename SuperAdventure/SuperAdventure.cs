using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "home", "This Is Your House");

            Quest quest = new Quest();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text = "123";
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Hello World";
        }
    }
}
