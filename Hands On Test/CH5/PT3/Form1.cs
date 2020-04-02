using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(LengthB.Text);
            double width = Convert.ToDouble(WidthB.Text);

            double sq = length * width;
            double tot;
            Area.Text = $"Area: {sq} sq feet";
            if(sq >= 600) { Fee.Text = "Weekly Fee: $50.00"; tot = 50 * 20; }
           else if (sq >= 400) { Fee.Text = "Weekly Fee: $35.00"; tot = 35 * 20; }
            else { Fee.Text = "Weekly Fee: $25.00"; tot = 25 * 20; }

            Season.Text = "Season Length: 20 Weeks";
            Total.Text = $"Total Cost: {tot:C2} ";
        }
    }
}
