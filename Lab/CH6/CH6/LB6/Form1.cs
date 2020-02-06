using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCal_Click(object sender, EventArgs e)
        {
            const double height = 9;
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);
            double area = CalculateTotalArea(length, width);
            lblResult.Text = $" {area}";
            double cost = CalculatePaintEstimate(area);

            lblCost.Text = $"{cost:C}";






        }
        private double CalculateTotalArea(double length, double width)
        {
            double lengthH = length * 9 * 2;
            double widthH = width * 9 * 2;
            double area = lengthH + widthH;

            return area;








        }
        private double CalculatePaintEstimate(double area){
        
            double cost = area * 6;

            return cost;

}



    }
    }

