using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ISK_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Show local time in status bar
            toolStripStatusLabel1.Text = "Local Time: " + DateTime.Now.ToString("HH:mm");

            //Use the offset from current time to figure out EVE time
            TimeZone zone = TimeZone.CurrentTimeZone;
            double offset = zone.GetUtcOffset(DateTime.Now).TotalHours;
            DateTime dt = DateTime.Now.AddHours(-offset);
            //Show EVE Time in the status bar
            toolStripStatusLabel2.Text = "EVE Time: " + dt.ToString("HH:mm");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the About Form
            Form Form2 = new Form2();

            Form2.Show();
        }

        //Character count to be added to each time the button is clicked
        int chars = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Each time the button is pressed, add a CharacterControl to the flow panel.
            CharacterControl cc = new CharacterControl();
            flow1.Controls.Add(cc);

            //Add 1 to the character count
            chars++;
            CharCount.Text = chars.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save all the info in a CSV file
        }
    }
}
