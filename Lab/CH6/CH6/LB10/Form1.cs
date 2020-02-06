using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            ShowAnswer();
        }
        private void ShowAnswer()
        {
            if (txtHere.Text == "") { label2.Text = " I Dont Know"; }
            else
            {
                Random rnd = new Random(); int here = rnd.Next(1, 4);
                if (here == 1) { label2.Text = "Saturday"; }
                if (here == 2) { label2.Text = "Next Week"; }
                if (here == 3) { label2.Text = "Right Now"; }

            }
            return;
        }
    }
}
