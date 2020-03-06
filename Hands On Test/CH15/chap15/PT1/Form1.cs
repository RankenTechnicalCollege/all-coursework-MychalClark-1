using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT1
{
    public partial class Form1 : Form
    {
        
        List<ILoan> loans = new List<ILoan>();
        public Form1()
        {
            loans.Add(new ShortTermLoan("", 0));
            loans.Add(new LongTermLoan("", 0));



            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblLastPayment.Text = "";
            lblTerm.Text = "";
            lblLastInterest.Text = "";

            string loanName = txtName.Text;
            string enterAmount = txtAmount.Text;
            if (enterAmount.IndexOf('-') == 0) { lblName.Text = "You can not enter a negative number"; }
            else
            {
                enterAmount = String.Join("", enterAmount.Where(char.IsDigit));

            double amount = Convert.ToDouble(enterAmount);
            
            
            if (radioLong.Checked) { loans[1] = new LongTermLoan(loanName, amount); lblTerm.Text = $"Long-Term loan of {loans[1].Balance:C}"; }
            if (radioShort.Checked) { loans[0] = new ShortTermLoan(loanName, amount); lblTerm.Text = $"Short-Term loan of {loans[0].Balance:C}"; }
            lblName.Text = loanName; }
            
            


        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (radioLong.Checked) { loans[1].MakePayment(); lblLastPayment.Text = $"After the last payment the loan is down to {loans[1].Balance:C}";
                loans[1].ApplyInterest(); lblLastInterest.Text = $"After the last Interest accumulation the loan is now {loans[1].Balance:C}";
            }
            if (radioShort.Checked) {
                loans[0].MakePayment(); lblLastPayment.Text = $"After the last payment the loan is down to {loans[0].Balance:C}";
                loans[0].ApplyInterest(); lblLastInterest.Text = $"After the last Interest accumulation the loan is now {loans[0].Balance:C}";
            }

        }

        private void radioShort_CheckedChanged(object sender, EventArgs e)
        {
            loans[0] = new ShortTermLoan("", 0);
            loans[1] = new LongTermLoan("", 0);
            lblName.Text = "";
            lblLastPayment.Text = "";
            lblTerm.Text = "";
            lblLastInterest.Text = "";
        }

        private void radioLong_CheckedChanged(object sender, EventArgs e)
        {
            loans[0] = new ShortTermLoan("", 0);
            loans[1] = new LongTermLoan("", 0);
            lblName.Text = "";
            lblLastPayment.Text = "";
            lblTerm.Text = "";
            lblLastInterest.Text = "";
        }
    }
}
