using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        List<Photo> myUnframed = new List<Photo>();
        List<MattedPhoto> myMatted = new List<MattedPhoto>();
        List<FramedPhoto> myFramed = new List<FramedPhoto>();
        public Form1()
        { myUnframed.Add(new Photo(0, 0));
            myMatted.Add(new MattedPhoto(0,0, Color.BLACK));
            myFramed.Add(new FramedPhoto(0, 0, Material.PINE, Style.SIMPLE));
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblChoice.Text = "";

           



            float width = float.Parse(txtWidth.Text);
            float height = float.Parse(txtHeight.Text);
            if (radioUnframed.Checked == true)
            {
                myUnframed[0] = new Photo(width, height);
                lblCost.Text = $"Cost: {myUnframed[0].Price}";
                lblChoice.Text = myUnframed[0].ToString() + " UnframedPhoto";
            }



            else if (radioMatted.Checked == true)
            {
                myMatted[0].Width = width;
                myMatted[0].Height = height;

                if (radioBlack.Checked == true) { myMatted[0].Color = Color.BLACK; }
                if (radioRed.Checked == true) { myMatted[0].Color = Color.RED; }
                if (radioGreen.Checked == true) { myMatted[0].Color = Color.GREEN; }
                if (radioBlue.Checked == true) { myMatted[0].Color = Color.BLUE ; }
                if (radioWhite.Checked == true) { myMatted[0].Color = Color.WHITE; }

                lblCost.Text = $"Cost: {myMatted[0].Price }";
                lblChoice.Text = myMatted[0].ToString();
            }

            else if (radioFramed.Checked == true)
            {
                myFramed[0].Width = width;
                myFramed[0].Height = height;

                if (radioPine.Checked == true) { myFramed[0].Material = Material.PINE; }
                if (radioOak.Checked == true) { myFramed[0].Material = Material.OAK; }
                if (radioSteel.Checked == true) { myFramed[0].Material = Material.STEEL; }
                if (radioSilver.Checked == true) { myFramed[0].Material = Material.SILVER; }
                if (radioGold.Checked == true) { myFramed[0].Material = Material.GOLD; }

                if (radioSimple.Checked == true) { myFramed[0].Style = Style.SIMPLE; }
                if (radioModern.Checked == true) { myFramed[0].Style = Style.MODERN; }
                if (radioAntique.Checked == true) { myFramed[0].Style = Style.ANTIQUE; }
                if (radioVintage.Checked == true) { myFramed[0].Style = Style.VINTAGE; }
                if (radioEclectric.Checked == true) { myFramed[0].Style = Style.ECLECTIC; }

                lblCost.Text = $"Cost: {myFramed[0].Price }";
                lblChoice.Text = myFramed[0].ToString();
            }

        }
    }
}
