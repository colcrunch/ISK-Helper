﻿using System;
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
        private void addCharacter_Click(object sender, EventArgs e)
        {
            //Each time the button is pressed, add a CharacterControl to the flow panel.
            CharacterControl cc = new CharacterControl();
            flow1.Controls.Add(cc);

            //Add 1 to the character count
            chars++;
            CharCount.Text = chars.ToString();

        }

        private void save_Click(object sender, EventArgs e)
        {
            //Save all the info in a CSV file
            
            
            //List that will contain the content for writing to the CSV file.
            List<string> characterinfo = new List<string>();

            //Add the headers for the file to the list
            characterinfo.Add("Name,Start Time,End Time,Hours Mined, Hourly Pay (millions), End Pay (millions)");

            //Go through all of the CharacterControls in the FlowLayoutPanel
            foreach (CharacterControl cc in flow1.Controls)
            {
                //List that contains the info from each character
                List<string> charinfo = new List<string>();
                
                //Add each bit of info to the charinfo list
                charinfo.Add(cc.charName.Text);
                charinfo.Add(cc.startTime.Text);
                charinfo.Add(cc.endTime.Text);
                cc.Hours();
                charinfo.Add(cc.Hrs.ToString("#.##"));
                charinfo.Add(cc.pay.Value.ToString());

                //Calculate total pay
                double tpay;
                double hpay = Convert.ToDouble(cc.pay.Value);
                tpay = (cc.Hrs * hpay);

                //Add total pay to list
                charinfo.Add(tpay.ToString());

                //Join charinfo to a string then
                string cinfo = string.Join(",", charinfo);

                //Add the charinfo to the characterinfo list
                characterinfo.Add(cinfo);
            }

            //Join CharacterInfo list together with each item being a new line
            string characters = string.Join(" \n", characterinfo);

            //Write characters to file
            string date = OpDate.Text.Replace("/", "");
            System.IO.StreamWriter file = new System.IO.StreamWriter(string.Format(@"{0}\ops\op-" + OpName.Text.Replace(" ", "_") + "-" + date + ".txt", Directory.GetCurrentDirectory()));
            file.WriteLine(characters);
            file.Close();

        }
    }
}
