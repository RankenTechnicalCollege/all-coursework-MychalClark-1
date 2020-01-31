using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] movie = { "bad boys for life", "dolittle", "frozen 2" };
            string[] pub = { "bilall fallah", "stephen gaghan", "chris buck"};
            string[] desc = { "Boys Being Bad", "A Man Who talks to animals","A cold cold Queen."};

            textBox1.Text.ToLower();
            string enter = textBox1.Text;

            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Contains(enter)|| pub[i].Contains(enter)) { Namer.Text = $"{movie[i]}"; Direct.Text = $"{pub[i]}"; Description.Text = $"{desc[i]}"; break; }


                else { Namer.Text = $"Movie Not Found"; Direct.Text = $"Movie Not Found"; Description.Text = $"Movie Not Found"; }

            }
        }
    }
}
