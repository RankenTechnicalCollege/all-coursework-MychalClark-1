using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal balance = 0;
        bool here;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string account = txtAccount.Text;
            string pin = txtPin.Text;
            Login(account, pin);
            
        }

        private bool Login(string account, string pin) {

            if (account.All(char.IsDigit) && pin.All(char.IsDigit)) { lblName.Text = "Welcome Mr. Smith!"; here = true; return true; }
            else { lblName.Text = "invalid Login"; balance = 0;lblBalance.Text = "*" ; here = false; return false; };
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();

        }
       private void Logout() { balance = 0; lblBalance.Text = "*"; lblName.Text = "*"; }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal up = 0;

            if (here == true) {decimal depo= MakeDeposit(up);balance +=depo ; lblBalance.Text = $"Your Balance is{balance:C}"; }

            else { };
            
        }
        private decimal MakeDeposit(decimal up) {
            decimal upper = Convert.ToDecimal(txtDeposit.Text);

           
             return upper; }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal bo = 0;
            if (here == true) { decimal with = MakeWithdraw(bo); balance -= with; lblBalance.Text = $"Your Balance is{balance:C}"; }

            else { };
        }
        private decimal MakeWithdraw(decimal bo) { decimal ok = Convert.ToDecimal(txtWidthdraw.Text) ; return ok; }
    }
}
