using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1: Form
    {
        List<NormalCard> Normal = new List<NormalCard>();
        List<ShinyCard> Shiny = new List<ShinyCard>();
        List<ICard> showCard = new List<ICard>();
        public Form1()
        {
            Normal.Add(new NormalCard("charizard", Properties.Resources.charizard, 1));
            Normal.Add(new NormalCard("decidueye", Properties.Resources.decidueye, 2));
            Normal.Add(new NormalCard("dragonair", Properties.Resources.dragonair, 3));
            Normal.Add(new NormalCard("dratini", Properties.Resources.dratini, 4));
            Normal.Add(new NormalCard("gardevoir", Properties.Resources.gardevoir, 5));
            Normal.Add(new NormalCard("kommo-o", Properties.Resources.kommo_o, 6));
            Normal.Add(new NormalCard("mawile", Properties.Resources.mawile, 7));
            Normal.Add(new NormalCard("pikachu-f", Properties.Resources.pikachu_f, 8));
            Normal.Add(new NormalCard("rockruff", Properties.Resources.rockruff, 9));
            Normal.Add(new NormalCard("serperior", Properties.Resources.serperior, 10));
            Normal.Add(new NormalCard("zorua", Properties.Resources.zorua, 11));
            //
            Shiny.Add(new ShinyCard("Charizard(Shiny)", Properties.Resources.charizard_shiny, 20, new Font("Helvetica", 1), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("decidueye(Shiny)", Properties.Resources.decidueye_shiny, 21, new Font("Helvetica", 2), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("dragonair(Shiny)", Properties.Resources.dragonair_shiny, 22, new Font("Helvetica", 3), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("dratini(Shiny)", Properties.Resources.dratini_shiny, 23, new Font("Helvetica", 3), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("gardevoir(Shiny)", Properties.Resources.gardevoir_shiny, 24, new Font("Helvetica", 4), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("kommo-o(Shiny)", Properties.Resources.kommo_o_shiny, 25, new Font("Helvetica", 5), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("mawile(Shiny)", Properties.Resources.mawile_shiny, 26, new Font("Helvetica", 6), Color.Goldenrod, Color.Pink));

            Shiny.Add(new ShinyCard("pikachu-f(Shiny)", Properties.Resources.pikachu_f_shiny, 27, new Font("Helvetica", 8), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("rockruff(Shiny)", Properties.Resources.rockruff_shiny, 28, new Font("Helvetica", 9), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("serperior(Shiny)", Properties.Resources.serperior_shiny, 29, new Font("Helvetica", 10), Color.Goldenrod, Color.Pink));
            Shiny.Add(new ShinyCard("zorua(Shiny)", Properties.Resources.zorua_shiny, 30, new Font("Helvetica", 11), Color.Goldenrod, Color.Pink));

            showCard.Add(Shiny[1]);
            showCard.Add(Shiny[1]);
            showCard.Add(Shiny[1]);
            showCard.Add(Shiny[1]);
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCard.Sort();

            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            lblOne.ForeColor = Color.Black;
            lblTwo.ForeColor = Color.Black;
            lblThree.ForeColor = Color.Black;
            lblFour.ForeColor = Color.Black;
            Random rand = new Random();

            int normalPick = rand.Next(11);
            int shinyPick = rand.Next(11);

            int randomPick = rand.Next(11);

            for (int i = 0; i < 4; i++)
            {

                 randomPick = rand.Next(11);

                if(randomPick <= 1) {
                    shinyPick = rand.Next(11);
                    showCard[i] = (Shiny[shinyPick]);
                }
                 else
                {
                    shinyPick = rand.Next(11);
                    showCard[i] = (Normal[shinyPick]);

                }
               
                
               


            }
            
            showCard.Sort();
            for (int i = 0; i < 4; i++)
            {
                if (i == 3) { showCard[i].ShowCard(pictureBox1, lblOne); }
                if (i == 2) { showCard[i].ShowCard(pictureBox2, lblTwo); }
                if (i == 1) { showCard[i].ShowCard(pictureBox3, lblThree); }
                if (i == 0) { showCard[i].ShowCard(pictureBox4, lblFour); }

            }

        }

        private void lblOne_Click(object sender, EventArgs e)
        {

        }

        
    }
}
