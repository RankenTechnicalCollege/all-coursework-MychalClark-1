using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            List<string> digits = new List<string>();

           int idx = 0;
            int idxstop = 0;
           int cardSize = CardNum.Text.Length;
            string card = CardNum.Text.ToLower();
            string poundsign = "X";
           

            
            
        }

        private void CardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
