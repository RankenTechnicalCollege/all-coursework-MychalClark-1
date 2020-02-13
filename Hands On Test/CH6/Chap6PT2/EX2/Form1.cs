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
        public Form1()
        {
            InitializeComponent();
        }
        double subtotal = 0;
        double shirtCost = 13.75;


        private void button1_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            shirtCost = 13.75;
            int quantity = Convert.ToInt32(txtNum.Text);
            string code = txtCode.Text;

           float discount = CheckDiscountCode(code);

            ShowInvoice(quantity, discount);
        }
        private float CheckDiscountCode(string code ) {

            int index = 0;
            float discount = 0;
            if(code == "8264") { index = 1; }
            if (code == "5679") { index = 2; }
            if (code == "6483") { index = 3; }
            if (code == "6483") { index = 4; }
            if (code == "") { index = 5; }


            for (int i = 0; i < 5; i++)
            {   if(index == 0) { lblError.Text = "Invalid Discount Code"; break; }
                else if(index == 2) { lblError.Text = "30% DIscount Applied"; discount = 0.30F; break; }
                else if (index == 3) { lblError.Text = "20% DIscount Applied"; discount = 0.20F; break; }
                else if (index == 4) { lblError.Text = "10% DIscount Applied"; discount = 0.10F; break; }
                else if (index == 5) { lblError.Text = ""; break; }
            

            }


            return discount; }

        private void ShowInvoice(int quantity, float discount) {

            lblNumInvoice.Text = $"{quantity}";

            double discountConv = discount;
            double price = quantity * shirtCost;

            double discountApplied = price * discountConv;


            lblSub.Text = $"{subtotal}";

            lblTax.Text = $"{ discountApplied * price:C}";
            lblCost.Text = $"{shirtCost*discountConv:C}";
            lblSub.Text = "";
        }
    }
}
