using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double CM_PER_IN = 2.54;
            double inch = Convert.ToDouble(Inches.Text);

            double cent = inch * CM_PER_IN;

            Result.Text = $"{inch} inches is {cent} centimeters";
        } 
    }
}
