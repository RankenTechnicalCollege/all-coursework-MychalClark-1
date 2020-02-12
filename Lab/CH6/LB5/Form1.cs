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

        private void btn_Click(object sender, EventArgs e)
        {
            string enter = txt.Text;
            string result = ParseBid(enter);

           double resultm = Convert.ToDouble(result);

            if (resultm < 10) { lbl.Text = "Bid must be at least  $10"; }
            else { lbl.Text = $"{resultm:C} accepted!"; }
            

        }
        private string ParseBid(string enter)
        {
            string o;
            string okay = "";
            foreach (char n in enter)
            {
               o = n.ToString();
                if(o == "0"|| o == "1" || o == "2" || o == "3" || o == "4" || o == "5" || o == "6" || o == "7" || o == "8" || o == "9" || o == ".") { okay += o; }
            }
            return okay;
        }
    }
    }

