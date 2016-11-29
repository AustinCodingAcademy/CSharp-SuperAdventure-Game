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

            location location = new location(1, "Home","This is your house");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house";

            location test1 = new location(1, "Your House", 
                "This is your house");
            location test2 = new location(1, "Your House",
                "This is your house", null, null, null);


        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text = "123";
        }
    }
}
