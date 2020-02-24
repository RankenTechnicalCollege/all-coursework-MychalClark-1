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
        private List<Job> Jobbers = new List<Job>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           string jobName = txtDesc.Text.ToLower();
            float hoursC = float.Parse(txtHours.Text);
            float hourlyR = float.Parse(txtRate.Text);
            bool found = false;
            for (int i = 0; i < Jobbers.Count; i++)
            {
              if(  Jobbers[i].Description.ToLower() == jobName) { Jobbers[i].Description = jobName; Jobbers[i].HoursToComplete = hoursC; Jobbers[i].HourlyFee = hourlyR ;found = true; break;  }
               
            }
            if (found == false) { Jobbers.Add(new Job(jobName, hoursC, hourlyR)); }

            lblDesc.Text = $"{jobName}";
            lblHours.Text = $"{hoursC}";
            lblRate.Text = $"{hourlyR}";

            double total = 0;
            for (int i = 0; i < Jobbers.Count; i++)
            {
                total += Jobbers[i].TotalFee + Jobbers[i].TRIPFEE();

            }
            lblTotal.Text = $"{total:C}";

        }

        
    }
}
