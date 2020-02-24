using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7
{
    public class Names
    {
        
        private string _name;

      public Names(string name)
        {
            _name = name;
        }

        public string GetName() => _name;

        public string ChangeName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}
