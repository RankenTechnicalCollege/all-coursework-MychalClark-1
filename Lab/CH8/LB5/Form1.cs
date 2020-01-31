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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] zip = { "63101", "63103", "63105", "63109", "63113", "63118", "63130", "63133", "63136", "63137" };
            int[] pay = { 20, 12, 25, 15,10, 23, 18, 20, 17, 12 };

            string entered = textBox1.Text;

            for (int i = 0; i < zip.Length; i++)
            {if(zip[i] == entered) { result.Text = $"{pay[i]:C}"; break; }

            }
        }
    }
}
