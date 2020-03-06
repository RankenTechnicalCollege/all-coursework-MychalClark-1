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
    public partial class Form1 : Form
    {
        List<Champion> Champs = new List<Champion>();
        List<Ability> LAbilities = new List<Ability>();
        List<Ability> RAbilities = new List<Ability>();
        List<Ability> QAbilities = new List<Ability>();
        List<Ability> FAbilities = new List<Ability>();
        List<Ability> EAbilities = new List<Ability>();

        public Form1()
        { LAbilities.Add(new Ability("miniguns"));
            RAbilities.Add(new Ability("Missle Launcher"));
            QAbilities.Add(new Ability("Emitter"));
            FAbilities.Add(new Ability("Advance"));
            EAbilities.Add(new Ability("Hexa Fire"));

            LAbilities.Add(new Ability("Cannon"));
            RAbilities.Add(new Ability("Dredge Anchor"));
            QAbilities.Add(new Ability("Shell Shield"));
            FAbilities.Add(new Ability("Shell Spin"));
            EAbilities.Add(new Ability("Ancient Rage"));

            LAbilities.Add(new Ability("Rocket Launcher"));
            RAbilities.Add(new Ability("Fire Spit"));
            QAbilities.Add(new Ability("Salvo"));
            FAbilities.Add(new Ability("Thrust"));
            EAbilities.Add(new Ability("Dragon Punch"));

            LAbilities.Add(new Ability("Auto Rifle"));
            RAbilities.Add(new Ability("Nade Launcher"));
            QAbilities.Add(new Ability("Fire Bomb"));
            FAbilities.Add(new Ability("Hunter's Mask"));
            EAbilities.Add(new Ability("CrossFire"));

            LAbilities.Add(new Ability("Throwing Axe"));
            RAbilities.Add(new Ability("Crippling Throw"));
            QAbilities.Add(new Ability("Blossom"));
            FAbilities.Add(new Ability("Vine"));
            EAbilities.Add(new Ability("Whirlwind"));

            LAbilities.Add(new Ability("Ice Staff"));
            RAbilities.Add(new Ability("Ice Block"));
            QAbilities.Add(new Ability("Blink"));
            FAbilities.Add(new Ability("Soar"));
            EAbilities.Add(new Ability("Ice Storm"));


            Champs.Add(new Champion("Ruckus", ChampionType.FRONT_LINE, LAbilities[0], RAbilities[0], QAbilities[0], FAbilities[0], EAbilities[0]));
            Champs.Add(new Champion("Makoa", ChampionType.FRONT_LINE, LAbilities[1], RAbilities[1], QAbilities[1], FAbilities[1], EAbilities[1]));
            Champs.Add(new Champion("Drogox", ChampionType.FRONT_LINE, LAbilities[2], RAbilities[2], QAbilities[2], FAbilities[2], EAbilities[2]));
            Champs.Add(new Champion("Tyra", ChampionType.FRONT_LINE, LAbilities[3], RAbilities[3], QAbilities[3], FAbilities[3], EAbilities[3]));
            Champs.Add(new Champion("Grover", ChampionType.FRONT_LINE, LAbilities[4], RAbilities[4], QAbilities[4], FAbilities[4], EAbilities[4]));
            Champs.Add(new Champion("Evie", ChampionType.FRONT_LINE, LAbilities[5], RAbilities[5], QAbilities[5], FAbilities[5], EAbilities[5]));

            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string myChamp = textBox1.Text;
            for (int i = 0; i < Champs.Count; i++)
            {
                if (Champs[i].Name.ToLower().Contains(myChamp)) { 
                    lblName.Text =$"{ Champs[i].Name}"; 
                    lblType.Text = $"{Champs[i].Type}";
                    lblLeft.Text = $"LeftMouse: {LAbilities[i].Name}"; 
                    lblRight.Text =$"RightMouse: {RAbilities[i].Name}";
                    lblQ.Text = $"Q: {QAbilities[i].Name}";
            lblF.Text = $"F: {FAbilities[i].Name}";
                    lblE.Text = $"E: {EAbilities[i].Name}";
            break; }

                else { lblName.Text = "Champion Not Found"; lblType.Text = $"";
                    lblLeft.Text = $"";
                    lblRight.Text = $"";
                    lblQ.Text = $"";
                    lblF.Text = $"";
                    lblE.Text = $"";
                }
            }
        }
    }
}
