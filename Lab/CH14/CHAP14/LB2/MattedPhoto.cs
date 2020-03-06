using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    enum Color
    { BLACK =0,
      RED=1,
      GREEN=2,
      BLUE=4,
      WHITE=7,
    }

    class MattedPhoto: Photo
    {
        protected Color _color;

        public MattedPhoto(float width, float height, Color color):base(width, height) {

            

            _color = color; }

        public Color Color { get => _color; set => _color = value; }


        public override string ToString()
        {
            return base.ToString() + $"MattedPhoto {_color}";
        }
        public override float Price => base.Price + 10;
    }
}
