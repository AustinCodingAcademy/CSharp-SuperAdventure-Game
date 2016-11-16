using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        public SuperAdventure()
        {
            InitializeComponent();

            Engine.Location location = new Engine.Location(1, "home", "This Is Your House");




            _player = new Engine.Player(10, 10, 20, 0, 1);

            Location test1 = new Engine.Location(1, "your house", "where you live");

            Item item = new Item(1, "key", "first key");
            Quest quest1 = new Quest(1, "", "", 100, 100);
            Location test3 = new Engine.Location(1, "", "", item, quest1, null);




        }

     /*   private void btnTest_Click(object sender, EventArgs e)
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
        */
    }
}
