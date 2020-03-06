using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Photo
    {
        protected float _width;
        protected float _height;
        private float _price;

        public Photo(float width, float height) { _width = width; _height = height;

            
        }

        public float Width { get => _width; set => _width = value; }
        public float Height { get => _height; set => _height = value; }
        public virtual float Price
        {
            get { float price = 0;

                if (_height == 10 && _width == 8) { price = 3.99f; } 
             else if(_height == 12 && _width == 10) { price = 5.99f; }
                else { price = 9.99f; }
                return price;

            } 
        
        }


        public override string ToString()
        {
            return $"{_width}x{_height}";
        }


    }
}
