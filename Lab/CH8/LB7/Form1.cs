using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] game = { "player unknown's battlegrounds (pubg)", "league of legends", "call of duty: black ops iii", "battlefield 4", "super mario odyssey" };
            string[] pub = { "Bluehole", "Riot Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
            int[] price = { 35, 0, 60, 20, 60 };
            textBox1.Text.ToLower();
            string enter = textBox1.Text;

            for (int i = 0; i < game.Length; i++)
            {
                if (game[i].Contains(enter)) { Namer.Text = $"{game[i]}"; Pubb.Text = $"{pub[i]}"; Pricer.Text = $"{price[i]:C}"; break; }
                else { Namer.Text = $"Game Not Found"; Pubb.Text = $"Game Not Found"; Pricer.Text = $"Game Not Found"; }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
