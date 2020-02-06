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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int count = 0;
            string text = txtPhrase.Text;
           int vowels = CountVowels(text);
            
            
            lblResult.Text = $"There Are {vowels} Vowels In Your Phrase";
           

            
        }
       private int CountVowels(string vowels) {
            int counter = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                string vowelSub = vowels.Substring(i, 1);

                if( vowelSub == "i"|| vowelSub == "e" || vowelSub == "a" || vowelSub == "o" || vowelSub == "u") { counter++; }
                

            }

            return counter;
            
            
        }
    }
}
