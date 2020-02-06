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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(txtGpa.Text);
            double score = Convert.ToDouble(txtScore.Text);
           

            if (IsStudentAccepted(gpa, score)) {
                lblResult.Text = "Accept";
            } 
            
            
            else 
            {
                lblResult.Text = "Reject";
            };


        }

        private bool IsStudentAccepted(double gpaH, double scoreH) {

            bool studentAccepted;
        
            if (scoreH >= 80) { studentAccepted = true; }

            else if (gpaH>=3.0 && scoreH >= 60) {  studentAccepted = true; }

            else if (gpaH<3.0 && scoreH < 60) { studentAccepted = false; }

            else { studentAccepted = false;}

            return studentAccepted;
        
        
        }
    }
}
