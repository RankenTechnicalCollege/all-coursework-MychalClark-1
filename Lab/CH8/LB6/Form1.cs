using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nights = Convert.ToInt32(textBox1.Text);
            int[] days = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] cost = { 200, 400, 540, 720, 800, 960, 1120, 1160 };
            int[] hey =  { 200, 200, 180, 180, 160, 160, 160, 145 };
            for (int i = 0; i < nights; i++)
            {
                if(days[i]== nights) { stay.Text = $"{cost[i]:C}"; coster.Text = $"{hey[i]:C}"; break; }
                if(nights> 8) { coster.Text = $"{145:C}"; stay.Text = $"{145*nights:C}"; break; }
            }
        }
    }
}
