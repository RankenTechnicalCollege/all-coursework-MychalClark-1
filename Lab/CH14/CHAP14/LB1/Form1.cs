using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        List<Letter> letters = new List<Letter>(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string trackingNum = txtNum.Text;
            if (String.IsNullOrEmpty(trackingNum)) { letters.Add(new Letter(txtRec.Text, DateTime.Parse(txtSent.Text))); }

            else { letters.Add(new CertifiedLetter(txtRec.Text, DateTime.Parse(txtSent.Text), txtNum.Text)); }
            

            string currentLabel = lblResult.Text;
            lblResult.Text = letters[letters.Count - 1].ToString() + "\n"+ currentLabel;


        }
    }
}
