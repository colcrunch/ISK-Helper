using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISK_Helper
{
    public partial class CharacterControl : UserControl
    {
        public CharacterControl()
        {
            InitializeComponent();
        }

        private void get_start_Click(object sender, EventArgs e)
        {
            //Select current time as start time
            startTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void get_end_Click(object sender, EventArgs e)
        {
            //Select current time as end time
            endTime.Text = DateTime.Now.ToString("HH:mm");
        }

        //Calculate the number of hours that a miner mined, with a publicly accesible value
        public double Hrs;
        public void Hours()
        {
            //Convert the startTime and endTime text boxes to actual time
            DateTime start = DateTime.Parse(startTime.Text);
            DateTime end = DateTime.Parse(endTime.Text);

                //What if the miner ends the day after they start, surely they didn't go back in time.
                if(end<start)
                {
                    end = end.AddDays(1);
                }

           //Do the actual math to arrive at the number of hours that the miner was present
           Hrs = (end - start).TotalHours;
        }
    }
}
