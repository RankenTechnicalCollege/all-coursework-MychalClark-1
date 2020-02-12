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
        int[] nums = new int[21];
        int i = 1;
        int min = 400;

        int max = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool hi = true;
            string enter = txtEnter.Text;

            foreach (char c in enter)
            {
                if (Char.IsLetter(c)) { 
                hi = false;
                txtEnter.Text = "Error Please retry."; }
            }

            if (hi == true) {

                int okay = Convert.ToInt32(enter);

                nums[i] = okay;
                

                CalculateStats(nums);
                
            }
            

        }
        private void CalculateStats( int[] nums) {
            
            double avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                avg += nums[i];


            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];


                if (nums[i] < min)
                {
                    min = nums[i];
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }


            lblNum.Text= $"{i}";
            lblLow.Text = $"{min}";

            
            lblSum.Text = $"{sum}";
            lblAvg.Text = $"{avg/(i)}";
            lblHigh.Text = $"{max}";
            i++;
            return; }
    }
}
