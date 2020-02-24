using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        public Room(string name, int width, int length) {

            _area = width * length;

            int remain = _area % 12;

            _boxes = _area/12 + 1;

            if (remain != 0) { _boxes++; }

            _length = length;
            _name = name;
            _width = width;
            
          
        }


       

        public string Name { get { return _name; } }
        public int Length { get { return _length; } }
        public int Width { get { return _width; } }
        public int Area { get { return _area; } }
        public int Boxes { get { return _boxes; } }
        public string Display() { return String.Format($"\n"+$"{Name} ({Width}x{Length}) needs {Boxes} boxes"); }
    }
}
