using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    class NormalCard :ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;

        private NormalCard() { }
        public NormalCard(string name, System.Drawing.Image image, double value) { 
            _name = name;
            _image = image;
            _value = value;
            
        }
        public void ShowCard(PictureBox picture, Label label) { picture.Image = _image; label.Text = _name; }
        
        public string Name { get => _name; }
        public System.Drawing.Image Image { get => _image; }
        public double Value { get => _value; }

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

    }
}
