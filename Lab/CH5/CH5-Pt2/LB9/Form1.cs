using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int total = 0;
            Phrase.Text.ToLower();
            int csize = Phrase.Text.Length;
            string ctext = Phrase.Text;

            for (int i = 0; i < csize; i++)
            {
                if (ctext.Substring(i , 1  ) == "a") { total += 1; }
                if (ctext.Substring(i , 1  ) == "e") { total += 1; }
                if (ctext.Substring(i , 1) == "i") { total += 1; }
                if (ctext.Substring(i , 1) == "o") { total += 1; }
                if (ctext.Substring(i , 1 ) == "u") { total += 1; }
            }
            
            Result.Text = $"There are {total} vowels in your phrase.";
        }
    }
}
