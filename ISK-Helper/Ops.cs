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
using LINQtoCSV;

namespace ISK_Helper
{
    public partial class Ops : Form
    {
        public Ops()
        {
            InitializeComponent();
        }

        class Character
        {
            [CsvColumn(FieldIndex = 0, CanBeNull = false, Name = "Name")]
            public string Name { get; set; }
            [CsvColumn(FieldIndex = 1, CanBeNull = false, Name = "Start Time")]
            public string StartTime { get; set; }
            [CsvColumn(FieldIndex = 2, CanBeNull = false, Name = "End Time")]
            public string EndTime { get; set; }
            [CsvColumn(FieldIndex = 3, CanBeNull = false, Name = "Hours Mined")]
            public string HoursMined { get; set; }
            [CsvColumn(FieldIndex = 4, CanBeNull = false, Name = "HourlyPay(M)")]
            public string HourlyPay { get; set; }
            [CsvColumn(FieldIndex = 5, CanBeNull = false, Name = "EndPay(M)")]
            public string EndPay { get;  set;}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dissplay an OpenFileDialoge to allow the user to open a CSV file.
            //OpenFileDialog openfile = new OpenFileDialog();
            openFileDialog1.InitialDirectory = string.Format(@"{0}\ops", Directory.GetCurrentDirectory()) ;
            openFileDialog1.Filter = "|*.txt";
            openFileDialog1.Title = "Select an Op CSV File";

            //Show the dialoge
            //If the user clicked ok in the dialogue
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save file path to a string
                string file = openFileDialog1.FileName;

                //Tell CsvFileDescription that the Separator is a comma and to ignore the first line
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = true
                };

                //Define a CsvContext object so the file can be read
                CsvContext cc = new CsvContext();

                //Read the CSV file to a list
                var characters = cc.Read<Character>(file, inputFileDescription).ToList();

                //Display data in the view.
                dataGridView1.DataSource = characters;

            }

        }
    }
}
