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

        private void estimate_Click(object sender, EventArgs e)
        {
            int windSpeedo = int.Parse(windSpeed.Text);
            if (windSpeedo >= 74) { cate.Text = "Category 1"; }
             if (windSpeedo >= 96) { cate.Text = "Category 2"; }
             if (windSpeedo >= 111) { cate.Text = "Category 3"; }
             if (windSpeedo >= 130) { cate.Text = "Category 4"; }
             if (windSpeedo >= 157) { cate.Text = "Category 5"; }
              if (windSpeedo <74){ cate.Text = "Not a Hurricane"; }
        }
    }
}
