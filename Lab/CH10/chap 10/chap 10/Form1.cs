using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap_10
{
    public partial class Form1 : Form
    {
        SuperHero[] heros =
        {
            new SuperHero(){Name="None", Likes="",Dislikes="",Biography="",Image=null, SuperPower="", Url=""},
            new SuperHero(){Name="IronMan", Likes="Drinking",Dislikes="Captain America",Biography="Not only does Tony Stark have no super powers of his own, but the armor that gives him strength was also created to keep his damaged heart beating; he could not survive without his iron shell. Eventually his cardiac condition was corrected by a heart transplant, and a later that left him paralyzed was repaired with a microchip. So even without his high-tech costume Tony Stark is a mixture of man and machine, what science fiction writers call a cyborg.",Image=Properties.Resources.Iron_Man_AOU_Render, SuperPower="Flying", Url="https://www.superherostuff.com/biographies/ironmanbiography.html"},
            new SuperHero(){Name="HUlk", Likes="Smash",Dislikes="Red Hulk",Biography="Exposed to heavy doses of gamma radiation, scientist Bruce Banner transforms into the mean, green rage machine called the Hulk",Image=Properties.Resources.hulk, SuperPower="Super Strength", Url="https://www.marvel.com/characters/hulk-bruce-banner"},
            new SuperHero(){Name="Thor", Likes="Zeus",Dislikes="Loki",Biography="Thor Odinson is a fictional superhero appearing in American comic books published by Marvel Comics. The character, which is based on the Norse deity of the same name, is the Asgardian god of thunder who possesses the enchanted hammer, Mjolnir, which grants him the ability to fly and manipulate weather amongst his other superhuman attributes.",Image=Properties.Resources.thor, SuperPower="Lightning", Url="https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)"},
            new SuperHero(){Name="Black Panther", Likes="Mineral",Dislikes="Killmonger",Biography="eeking to address the dearth of black characters in comics, Lee and Kirby created T’Challa, a member of the royal family of the fictional African country of Wakanda.",Image=Properties.Resources.black_panther, SuperPower="Technology", Url="https://www.britannica.com/topic/Black-Panther-comic-book-character"},
            new SuperHero(){Name="Captain America", Likes="Fighting",Dislikes="Lying",Biography="Captain America is a fictional superhero appearing in American comic books published by Marvel Comics. Created by cartoonists Joe Simon and Jack Kirby, the character first appeared in Captain America Comics #1 (cover dated March 1941) from Timely Comics,",Image=Properties.Resources.captain, SuperPower="Super Everything", Url="https://en.wikipedia.org/wiki/Captain_America"}
        };
        public Form1()
        {
            InitializeComponent();
            CboHeros.Items.AddRange(heros);
            CboHeros.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = CboHeros.SelectedIndex;
            if(currentIndex == 0)
            {
                lblName.Text = "Select Hero";
            }
            else
            {
                lblName.Text = heros[currentIndex].Name;
                lblLikes.Text = heros[currentIndex].Likes;
                lblDislikes.Text = heros[currentIndex].Dislikes;
                lblBio.Text = heros[currentIndex].Biography;
                pictureBox1.Image = heros[currentIndex].Image;
                lblUrl.Text = heros[currentIndex].Url;
                lblSuper.Text = heros[currentIndex].SuperPower;

            }
        }
    }
}
