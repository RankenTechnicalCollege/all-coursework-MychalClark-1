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
    public partial class PokemonForm : Form
    {
        List<Pokemon> myPoke = new List<Pokemon>();
        
        List<IAbility> abilities = new List<IAbility>();

        private Pokemon _mon;
        
        

        public PokemonForm()
        {
            Random rand = new Random();
           

            myPoke.Add(new Pokemon("Charizard", Properties.Resources.charizard, null));
            myPoke.Add(new Pokemon("Decidueye", Properties.Resources.decidueye, null));
            myPoke.Add(new Pokemon("Dragonair", Properties.Resources.dragonair, null));
            myPoke.Add(new Pokemon("Dratini", Properties.Resources.dratini, null));
            myPoke.Add(new Pokemon("Gardevoir", Properties.Resources.gardevoir, null));
            myPoke.Add(new Pokemon("Kommo_o", Properties.Resources.kommo_o, null));
            myPoke.Add(new Pokemon("Rockruff", Properties.Resources.rockruff, null));


            abilities.Add(new MaximizeAbility());
            abilities.Add(new MinimizeAbility());
            abilities.Add(new NightModeAbility());
            abilities.Add(new DayModeAbility());
            abilities.Add(new WarpAbility());

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnRespawn_Click(object sender, EventArgs e)
        {
            Respawn();
           
            
        }
        public void Respawn() {
            Random rand = new Random();
            int randyA = rand.Next(5);
            int randy = rand.Next(7);
             ;

            _mon = myPoke[randy];

            pictureBox1.Image = _mon.Image;
            lblName.Text = _mon.Name;

            btnAttack.Text = abilities[randyA].GetName();
            

        }

        private void btnAttack_Click(object sender, EventArgs e)
        { object me;
            if(btnAttack.Text == "DayModeAbility") { abilities[3].Execute(this); }
            if (btnAttack.Text == "NightModeAbility") { abilities[2].Execute(this); }
            if (btnAttack.Text == "WarpAbility") { abilities[4].Execute(this); }
            if (btnAttack.Text == "MinimizeAbility") { abilities[1].Execute(this); }
            if (btnAttack.Text == "MaximizeAbility") { abilities[0].Execute(this); } }
        }
    }

