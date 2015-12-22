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
            starttime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void get_end_Click(object sender, EventArgs e)
        {
            endtime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
