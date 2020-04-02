using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(EnterGrade.Text);
          

            if (grade > 3.0) { Grade.Text = "Your Grade: A"; }
    if(3.0 >= grade && grade > 2.0) { Grade.Text = "Your Grade: B"; }
            if (2.0 >= grade && grade > 1.0) { Grade.Text = "Your Grade: C"; }
            if (1.0 >= grade && grade > 0.0) { Grade.Text = "Your Grade: D"; }
            if (grade <= 0.0) { Grade.Text = "Your Grade: F"; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
