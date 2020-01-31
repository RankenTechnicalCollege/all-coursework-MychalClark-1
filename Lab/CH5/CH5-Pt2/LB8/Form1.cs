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
        
        public double danM = 0;
       public double franM = 0;
       public double edM = 0;
        public double total = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnDan_Click(object sender, EventArgs e)
        {
            double sale = Convert.ToDouble(txtSale.Text);
            danM += sale;
            labelDan.Text = $"Danielle Sales: {danM:C2}";
            total = danM + edM + franM;
            Grand.Text = $"Grand Total: {total:C2}";
            if (danM > franM && danM > edM) { most.Text = "Danielle has the most sells"; }
            if (franM > danM && franM > edM) { most.Text = "Francis has the most sells"; }
            if (edM > danM && edM > franM) { most.Text = "Edward has the most sells"; }

        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            double sale = Convert.ToDouble(txtSale.Text);
            edM += sale;
            labelEd.Text = $"Edward Sales: {edM:C2}";
            total = danM + edM + franM;
            Grand.Text = $"Grand Total: {total:C2}";
            if (edM > danM && edM > franM) { most.Text = "Edward has the most sells"; }
            if (danM > franM && danM > edM) { most.Text = "Danielle has the most sells"; }
            if (franM > danM && franM > edM) { most.Text = "Francis has the most sells"; }
        }

        private void btnFran_Click(object sender, EventArgs e)
        {
            double sale = Convert.ToDouble(txtSale.Text);
            franM += sale;
            labelFran.Text = $"Francis Sales: {franM:C2}";
            total = danM + edM + franM;
            Grand.Text = $"Grand Total: {total:C2}";
            if (franM > danM && franM > edM) { most.Text = "Francis has the most sells"; }
            if (danM > franM && danM > edM) { most.Text = "Danielle has the most sells"; }
            if (edM > danM && edM > franM) { most.Text = "Edward has the most sells"; }
        }
    }
}
