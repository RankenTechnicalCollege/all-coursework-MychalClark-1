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
        private List<Game> mygame = new List<Game>();

        string[] games = { "Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops III ", "Battlefield 4", "Super Mario Odyssey" };
        string[] publishers = { "Bluehole", "Riot Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
            float[] prices = { 35, 0, 60, 20, 60 };

        public Form1()
        {
            
            InitializeComponent();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userGame = txtGame.Text;
           int gameNum = SearchForGame(userGame);
           ShowGameInfo(gameNum);
            
        }
        public int SearchForGame(string game) {
            int gameNum = -1;
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].ToLower().Contains(game.ToLower())) { gameNum = i; break;  }
               
            }
            if (gameNum == -1)
            {
                lblName.Text = $"Game Not Found";
                lblPrice.Text = $"Game Not Found";
                lblPub.Text = $"Game Not Found";
            }
            return gameNum;
        }
        public void ShowGameInfo(int gameNum) {
            mygame.Add(new Game(games[gameNum], publishers[gameNum], prices[gameNum]));
            

           
            lblName.Text = $"{mygame.Last().GetName()}";
            lblPrice.Text = $"${mygame.Last().GetPrice()}";
            lblPub.Text = $"{mygame.Last().GetPublisher()}";
        }
    }
}
