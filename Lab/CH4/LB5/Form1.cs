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

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            const double PERCENT_RAISE = 1.04;
            double sal1 = Convert.ToDouble(Sal1.Text);
            double sal2 = Convert.ToDouble(Sal2.Text);
            double sal3 = Convert.ToDouble(Sal3.Text);
            Year0.Text = $"Year{null,18} {Name1.Text}{null,28} {Name2.Text}{null,28} {Name3.Text}{null,18}";


            Year1.Text = $"2018{null,18} {sal1:C2}{null,18} {sal2:C2}{null,18} {sal3:C2}{null,18}";
            Year2.Text = $"2019{null,18} {sal1 * PERCENT_RAISE:C2}{null,18} {sal2 * PERCENT_RAISE:C2}{null,18} {sal3 * PERCENT_RAISE:C2}{null,18}";
            Year3.Text = $"2020{null,18} {sal1 * PERCENT_RAISE * PERCENT_RAISE:C2}{null,18} {sal2 * PERCENT_RAISE * PERCENT_RAISE:C2}{null,18} {sal3 * PERCENT_RAISE * PERCENT_RAISE:C2}{null,18}";




        }

        private void Year3_Click(object sender, EventArgs e)
        {

        }
    }
}
