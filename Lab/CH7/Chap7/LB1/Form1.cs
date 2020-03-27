using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblBmi.ForeColor = System.Drawing.Color.Black;
            
            try {
                string lbs = txtLbs.Text;
               string inches = txtInches.Text;
                if (!lbs.All(char.IsDigit)) { throw new InvalidWeightException(); }
                if (!inches.All(char.IsDigit)) { throw new InvalidHeightException(); }

                if (float.Parse(txtLbs.Text) < 70|| float.Parse(txtLbs.Text)> 300) { throw new InvalidWeightException();  }
                if (float.Parse(txtInches.Text) < 60 || float.Parse(txtInches.Text) > 84) { throw new InvalidHeightException(); }
                

                Bmi userBmi = Form1.CalcBmi(float.Parse(txtLbs.Text), float.Parse(txtInches.Text));
                lblBmi.Text = $"{userBmi.BMI}";
                lblCategory.Text = $"{userBmi.Weightcategory}";
            }
            catch (InvalidHeightException xe) { lblBmi.Text = xe.Message;lblBmi.ForeColor = System.Drawing.Color.Red; }
            catch (InvalidWeightException xe) { lblBmi.Text = xe.Message; lblBmi.ForeColor = System.Drawing.Color.Red; }


        }
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
            float bmi = (703 * weightInPounds) / (heightInInches * heightInInches);

            WeightCategory userLbs;

            if(bmi >= 30) { userLbs = WeightCategory.OBESE; }


            else if (bmi >= 25) { userLbs = WeightCategory.OVERWEIGHT; }

            else if (bmi >= 18.5) { userLbs = WeightCategory.NORMAL; }

            else { userLbs = WeightCategory.UNDERWEIGHT; }

            return new Bmi(weightInPounds, heightInInches, bmi, userLbs);

        }
    }
}
