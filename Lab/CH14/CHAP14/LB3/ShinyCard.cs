using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    class ShinyCard:ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;
        private System.Drawing.Font _font;
        private System.Drawing.Color _backColor;
        private System.Drawing.Color _foreColor;

        public ShinyCard(string name, System.Drawing.Image image, double value, System.Drawing.Font font, System.Drawing.Color backColor, System.Drawing.Color foreColor)
        {
            _name = name;
            _image = image;
            _value = value;
            _font = font;
            _backColor = backColor;
            _foreColor = foreColor;
        }

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image; label.Text = _name;
            picture.BackColor = _backColor;

            label.ForeColor = _foreColor;

        }

        

        public int CompareTo(ICard other)
        {
            if (this.Value > other.Value)
            {
                return 1;
            }
            else if (this.Value == other.Value)
            {
                return 0;
            }

            else  
            {
                return -1;
            }
        }

        public string Name { get => _name; }
        public System.Drawing.Image Image { get => _image; }
        public double Value { get => _value; }


    }
}
