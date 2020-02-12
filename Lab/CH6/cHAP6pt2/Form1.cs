using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cHAP6pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int  n1 = Convert.ToInt32(txt1.Text);
            int n2 = Convert.ToInt32(txt2.Text);
            int n3 = Convert.ToInt32(txt3.Text);
            int n4 = Convert.ToInt32(txt4.Text);
            Reverse4(ref n1,ref n2,ref n3,ref n4);

            txt1.Text = $"{n1}";
            txt2.Text = $"{n2}";
            txt3.Text = $"{n3}";
            txt4.Text = $"{n4}";

        }
        private void Reverse4(ref int a, ref int b, ref int c, ref int d)
        {
            int newA = Convert.ToInt32(txt1.Text);
            int newB = Convert.ToInt32(txt2.Text);
            int newC = Convert.ToInt32(txt3.Text);
            int newD = Convert.ToInt32(txt4.Text);

            a = newD;
            b = newC;
            c = newB;
            d = newA;
            return;

      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
