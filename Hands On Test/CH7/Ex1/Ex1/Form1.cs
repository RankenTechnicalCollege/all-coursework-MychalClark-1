using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        private TestStatistics _stats = new TestStatistics();
        

        
       
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            float score = 0;
            try { if (!float.TryParse(txtScore.Text, out score)) { throw new ArgumentException(); }
            if(score < 0 || score > 100) { throw new ArgumentException(); }
                else { _stats.Addscore(score); }
                

            }
            catch(ArgumentException){ lblError.Text = "please enter valid score";
            }

            lblNum.Text = $"{_stats.Count}";
            lblSum.Text = $"{_stats.Sum}";
            lblAvg.Text = $"{_stats.Average}";
            lblLow.Text = $"{_stats.Min}";
            lblHigh.Text = $"{_stats.Max}";
        }


    }
}
