using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB7
{
    public partial class Form1 : Form
    {
        private List<Names> mynames = new List<Names>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string createName = txtCreate.Text;
            addName(createName);
        }
        public void addName(string createName)
        {
            lblEnter.Text = "";
            int adder = 1;
            for (int i = 0; i < mynames.Count; i++)
            {
                if (mynames[i].GetName().ToLower() == createName.ToLower()) { lblError.Text = "Name All Ready Created"; adder = 0; break; }

            }

            if (adder == 1)
            {
                lblError.Text = "Name Created";

                mynames.Add(new Names(createName));
            }

            for (int i = 0; i < mynames.Count; i++)
            {
                lblEnter.Text += "\n"+$"{mynames[i].GetName()}";

            }
        }
       
            
        
        private void btnRespell_Click(object sender, EventArgs e)
        {
            string thisName = txtRedo.Text;
            string toThis = txtRespell.Text;
            changeSpelling(thisName, toThis);


        }
        public void changeSpelling(string thisName, string toThis) {
            lblEnter.Text = "";

            for (int i = 0; i < mynames.Count; i++)
            {
                if (mynames[i].GetName().ToLower() == thisName.ToLower()) { mynames[i].ChangeName = toThis; }
            }

            for (int i = 0; i < mynames.Count; i++)
            {
                lblEnter.Text += "\n" + $"{mynames[i].GetName()}";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
