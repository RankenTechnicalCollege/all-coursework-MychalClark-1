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

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int box1 = Convert.ToInt32(Box1.Text);
            int box2 = Convert.ToInt32(Box2.Text);
            int box3 = Convert.ToInt32(Box3.Text);
            int box4 = Convert.ToInt32(Box4.Text);

            int total = box1 + box2 + box3 + box4;

            int dozen = total / 12;

            int leftOver = total % 12;

            Result.Text=$"{total} eggs total, or {dozen} dozen and {leftOver} eggs";
        }
    }
}
