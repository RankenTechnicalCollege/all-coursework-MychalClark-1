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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            double gpa = double.Parse(gpaBox.Text);
            double testScores = double.Parse(testScore.Text);

            Convert.ToDouble(gpa);
            if (gpa >= 3 && testScores >= 60) { rejectOr.Text = "Accept"; }

            else if (testScores >= 80) { rejectOr.Text = "Accept"; }

            else { rejectOr.Text = "reject"; }

        }
    }
}
