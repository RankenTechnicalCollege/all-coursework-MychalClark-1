using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            lblShiftError.Text = "";
            lblEncodeError.Text = "";
            DecoderRing decoderRing = new DecoderRing();

            try
            {
                int shift = int.Parse(txtShift.Text);

                if (shift < 0 || shift > 25)
                {

                    lblShiftError.Text = "Invalid Shift";
                }
                else
                {
                    decoderRing.Shift = int.Parse(txtShift.Text);
                    
                    txtResult.Text = decoderRing.Encode(txtDecode.Text);
                }

            }
            catch(FormatException ex) { lblShiftError.Text = "Enter Value for Shift."; }

            catch(InvalidCharacterException exx) { lblEncodeError.Text = exx.Message; }

            

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            lblShiftError.Text = "";
            lblEncodeError.Text = "";
            DecoderRing decoderRing = new DecoderRing();

            try
            {
                int shift = int.Parse(txtShift.Text);

                if (shift < 0 || shift > 25)
                {

                    lblShiftError.Text = "Invalid Shift";
                }
                else
                {
                    decoderRing.Shift = int.Parse(txtShift.Text);

                    txtDecode.Text = decoderRing.Decode(txtResult.Text);
                }

            }
            catch (FormatException ex) { lblShiftError.Text = "Enter Value for Shift."; }

            catch (InvalidCharacterException exx) { lblEncodeError.Text = exx.Message; }

        }
    }
}
