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
        public Form1()
        {
            InitializeComponent();
        }

        double subtotal = 0;
        
        
        

        int smallNum = 0;
        int medNum = 0;
        int largeNum = 0;

        private void btnSmall_Click(object sender, EventArgs e)
        {
            smallNum += 1;
            lblSmall.Text = $"{smallNum}";

            string small = "small";
            
            AddShirt(small);
            ShowInvoice();



        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            medNum += 1;
            lblMed.Text = $"{medNum}";
            

            string medium = "medium";
            
            AddShirt(medium);
            ShowInvoice();

        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            largeNum += 1;
            lblLarge.Text = $"{largeNum}";

            string large = "large";
            
            AddShirt(large);
            ShowInvoice();



        }

        private void AddShirt(string shirt)
        {  if( shirt == "small") { subtotal += 9.99; }
            if (shirt == "medium") { subtotal += 10.99; }
            if (shirt == "large") { subtotal += 11.99; }

            
        }
        private void ShowInvoice() {
            double tax = subtotal * 0.07;

            lblSmallInvoice.Text = $"{smallNum}";
            lblMediumInvoice.Text = $"{medNum}";
            lblLargeInvoice.Text = $"{largeNum}";

            lblSub.Text = $"{subtotal:C}";
            lblTax.Text = $"{tax:C}";
            lblTotal.Text = $"{tax+subtotal:C}";




            groupInvoice.Visible = true; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            subtotal = 0;



            smallNum = 0;
            medNum = 0;
             largeNum = 0;
            groupInvoice.Visible = false;
            lblSmall.Text = $"0";
            lblMed.Text = $"0";
            lblLarge.Text = $"0";
        }
    }
}
