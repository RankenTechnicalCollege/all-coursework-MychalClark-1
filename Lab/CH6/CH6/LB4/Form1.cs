using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string[] chosenPhrases= GenerateFortune();
            lblFortune1.Text = chosenPhrases[0];
            lblFortune2.Text = chosenPhrases[1];



        }

        private string[] GenerateFortune()
        {
            string[] fortuneCookieOptions = { "Birthdays are like friends. The more you have the better.",
 "Your smile is a treasure to all who know you.",
 "You never hesitate to tackle the most difficult problems.",
 "The most obvious solution is not always the best.",
 "If you want the rainbow, you will have to tolerate the rain.",
 "The early bird gets the worm, but the second mouse gets the cheese.",
 "From listening comes wisdom and from speaking repentance.",
"A smile is your personal welcome mat."};

            Random random = new Random();
            int randomNumOne = random.Next(0, 8);
            int randomNumTwo = random.Next(0, 8);

            while(randomNumOne== randomNumTwo)
            {
                randomNumTwo = random.Next(0, 8);
            }

            string[] chosenPhrases = new string[2];
            chosenPhrases[0] = fortuneCookieOptions[randomNumOne];
            chosenPhrases[1] = fortuneCookieOptions[randomNumTwo];
            return chosenPhrases;
        }
    }
}
