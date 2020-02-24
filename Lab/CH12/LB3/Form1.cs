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
        private List<Account> accounts = new List<Account>();

        int thePerson = -1;
        
        public Form1()
        {
            accounts.Add(new Account("111111111","1111","Sam",0));
            accounts.Add(new Account("222222222", "2222", "dan", 0));
            accounts.Add(new Account("333333333", "3333", "fan", 0));
            accounts.Add(new Account("444444444", "4444", "man", 0));
            accounts.Add(new Account("555555555", "5555", "can", 0));

            InitializeComponent();
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccount.Text;
            string pinNum = txtPin.Text;
          Login(pinNum,accountNum);




        }
        public void Login(string pinNum, string accountNum)
        { thePerson  = 1;
            
            for (int i = 0; i < accounts.Count; i++)
            {if (accounts[i].GetAccountNumber() == accountNum && accounts[i].GetPin() == pinNum)
                {
                    thePerson = i; lblName.Text = $"Welcome {accounts[thePerson].GetName()}"; lblMoney.Text = $"Your account balance is ${accounts[thePerson].GetBalance()}"; break; 
                }
                else {  Logout(); lblName.Text = "Error"; lblMoney.Text = $"Error"; }

            }
           
            return;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal add =Convert.ToDecimal(txtDeposit.Text);
            MakeDeposit(add);

        }
        public void MakeDeposit(decimal more) {
            accounts[thePerson].MakeDeposit(more);
            lblMoney.Text = $"Your account balance is ${accounts[thePerson].GetBalance()}";
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal subtract = Convert.ToDecimal(txtWithdraw.Text);
            MakeWithdrawal(subtract);
        }
        public void MakeWithdrawal(decimal less) { accounts[thePerson].MakeWithdrawal(less);
            lblMoney.Text = $"Your account balance is ${accounts[thePerson].GetBalance()}";
        
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();

        }
        public void Logout() { thePerson = -1; lblMoney.Text = ""; lblName.Text = ""; }
        
    }
}
