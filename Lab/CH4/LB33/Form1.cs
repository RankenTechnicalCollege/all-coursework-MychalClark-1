using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilos = Convert.ToDouble(kiloBox.Text);

            double kiloToMiles = kilos / 1.609344;

            transform.Text = $"{kilos} kilometers is {kiloToMiles:F2} miles";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kiloBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void milesButton_Click(object sender, EventArgs e)
        {
            double miles = Convert.ToDouble(milesbox.Text);

           double milesTokilo = miles * 1.609344;

            transform.Text = $"{miles} miles is {milesTokilo:F2} Kilometers";


        }
    }
}
