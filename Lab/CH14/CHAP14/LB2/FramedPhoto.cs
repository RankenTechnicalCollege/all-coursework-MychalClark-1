using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    enum Material { PINE = 0, OAK = 1, STEEL = 2, SILVER = 3, GOLD = 4 }
    enum Style { SIMPLE = 0, MODERN = 1, ANTIQUE = 2, VINTAGE = 3, ECLECTIC = 4 }
    class FramedPhoto : Photo
    {
        protected Material _material;
        protected Style _style;

        public FramedPhoto(float width, float height, Material material, Style style) : base(width, height) { _material = material; _style = style; }

        public Material Material { get => _material; set => _material = value; }
        public Style Style { get => _style; set => _style = value; }

        public override string ToString()
        {
            return base.ToString() + $" FramedPhoto ({_material},{_style})";
        }
        public override float Price => base.Price + 25;


    }
}

