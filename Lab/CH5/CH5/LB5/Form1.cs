using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form1 : Form
    {
        int i = 0;

       
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
           int playerScore = Convert.ToInt32(PlayerScore.Text);
            int aiScore = Convert.ToInt32(AiScore.Text);
            i = 1;

            Random rnd = new Random();
            string[] aiChoice = { "rock", "paper", "cutter" };
            int aiIndex = rnd.Next(aiChoice.Length);
            if (aiIndex == 0) { Winner.Text = "Its A Tie"; AiPick.Text = "Ai Picks Rock"; }
            if (aiIndex == 1) { Winner.Text = "Computer Wins"; aiScore += 1; AiPick.Text = "Ai Picks Paper"; }
            if (aiIndex == 2) { Winner.Text = "Player 1 Wins"; playerScore += 1;  AiPick.Text = "Ai Picks Siccors"; }

            AiScore.Text = $"{aiScore}";
            PlayerScore.Text = $"{playerScore}";
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            int playerScore = Convert.ToInt32(PlayerScore.Text);
            int aiScore = Convert.ToInt32(AiScore.Text);
            i = 1;

            Random rnd = new Random();
            string[] aiChoice = { "rock", "paper", "cutter" };
            int aiIndex = rnd.Next(aiChoice.Length);
            if (aiIndex == 0) { Winner.Text = "Player 1 Wins"; playerScore += 1; AiPick.Text = "Ai Picks Rock"; }
            if (aiIndex == 1) { Winner.Text = "Its A Tie"; aiScore += 1; AiPick.Text = "Ai Picks Paper"; }
            if (aiIndex == 2) { Winner.Text = "Computer Wins"; aiScore += 1; ; AiPick.Text = "Ai Picks Siccors"; }

            AiScore.Text = $"{aiScore}";
            PlayerScore.Text = $"{playerScore}";

        }

        private void Siccors_Click(object sender, EventArgs e)
        {
            int playerScore = Convert.ToInt32(PlayerScore.Text);
            int aiScore = Convert.ToInt32(AiScore.Text);
            i = 1;

            Random rnd = new Random();
            string[] aiChoice = { "rock", "paper", "cutter" };
            int aiIndex = rnd.Next(aiChoice.Length);
            if (aiIndex == 0) { Winner.Text = "Computer Wins";  aiScore += 1; AiPick.Text = "Ai Picks Rock"; }
            if (aiIndex == 1) { Winner.Text = "Player 1 Wins"; playerScore += 1; AiPick.Text = "Ai Picks Paper"; }
            if (aiIndex == 2) { Winner.Text = "Its A Tie";   AiPick.Text = "Ai Picks Siccors"; }

            AiScore.Text = $"{aiScore}";
            PlayerScore.Text = $"{playerScore}";
        }
    }
}
