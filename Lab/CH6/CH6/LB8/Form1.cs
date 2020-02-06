using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string wood = GetWood();
           int drawers= GetDrawers();

           double cost = CalculateWoodCost(wood);

            double drawerCost = CalculateDrawerCost(drawers);

            double totoal = CalculateTotalCost(wood, drawers);

            txtType.Text = $"{wood}";

            lblDrawers.Text = $"{drawerCost:C}";
            lblWood.Text = $"{cost:C}";
            lblTotal.Text = $"{totoal:C}";
            










        }
        private string GetWood()
        {
            string type = txtType.Text;
            type.ToLower();

            if (type == "o") { type = "Oak"; }

           else if (type == "m") { type = "Mahagony"; }

          else  if (type == "p") { type = "Pine"; }


            else { type = "Other";  };

            return type;
            
        }
            private int GetDrawers() {
            int drawCount = Convert.ToInt32(txtDrawers.Text);

            
            return drawCount; }
        private double CalculateWoodCost(string wood) {
            double cost = 0;
            if (wood == "Oak") { cost = 140;  }
           else if (wood == "Mahagony") { cost = 180;  }

           else if (wood == "Pine") { cost = 100;  }

            else { cost = 180; }

            return cost;
        }
        private double CalculateDrawerCost(double drawerss) {double dra = drawerss * 30; return dra; }
        private double CalculateTotalCost(string wood, int drawie) {
            double cost = 0;
            if (wood == "Oak") { cost = 140; }
            else if (wood == "Mahagony") { cost = 180;  }

            else if (wood == "Pine") { cost = 100;  }

            else { cost = 180; }

            int drawiee = drawie * 30;

            cost += drawiee;

            return cost;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
