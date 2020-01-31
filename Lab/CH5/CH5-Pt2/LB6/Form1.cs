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
        List<double> numList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Nscores_Click(object sender, EventArgs e)
        {

        }

        private void Average_Click(object sender, EventArgs e)
        {

        }

        private void r_Click(object sender, EventArgs e)
        {
            
            double score = Convert.ToDouble(Score.Text);

            if (score == 999)
            {
                
               Nscores.Text=$"Number Of Scores:{numList.Count}";
                Sum.Text=$"Sum Of Test Scores: {numList.Sum()}";
               Average.Text=$"Average Of Test Scores: {numList.Average()}";
                Lowest.Text=$"Lowest Test Score: {numList.Min()}";
                Highest.Text=$"Highest Test Score: {numList.Max()}";
                
            }
            else if (score < 0 || score > 100) { Nscores.Text="Invalid Score"; }
            else { numList.Add(score); Nscores.Text = "Score Accepted!"; }
        }
    }
}
