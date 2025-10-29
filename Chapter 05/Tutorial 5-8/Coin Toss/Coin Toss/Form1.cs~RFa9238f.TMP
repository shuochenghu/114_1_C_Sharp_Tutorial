using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // Variable to indicate which side is up
            int sideUp;

            // Create a Random object.
            Random rand = new Random();

            // Get a random integer in the range of 0 through 1.
            // 0 means tails up, 1 means heads up.
            sideUp = rand.Next(2);

            // Display the side that is up.
            if (sideUp == 0)
            {
                // Display tails up.
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                // Display heads up.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
