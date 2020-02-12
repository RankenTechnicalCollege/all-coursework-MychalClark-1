using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string words = txtEnter.Text;

            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            SortWords(split);

            

            
        }
        private string[] SortWords(string[] splitter) 
        { int i = 0;

            foreach (string s in splitter)
            {

                if (s.Trim() != "")
                { i++; splitter[i] = s; }
                   
            }
            lblEnter.Text = $"{splitter[2]}";
            
            return splitter;


        }
    }
}
