using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        private string _floater = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArit_Click(object sender, EventArgs e)
        {
            int ok = 0;
            int no = 1;
            try
            {
                int yes = no / ok;
                
               
            }
            catch (ArithmeticException) { lblError.Text = "you make arithmetic error"; }

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string me = "me";

            try { int score = Convert.ToInt32(me); }

            catch (FormatException) { lblError.Text = "You've made invalid Format error."; }
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            try
            {
                obj me;

                int a = Convert.ToInt32(me);
            }

            catch (InvalidCastException) { lblError.Text = "Invalid cast"; }


            
        }

        private void Null_Click(object sender, EventArgs e)
        {
           

        }
        
    }
}
