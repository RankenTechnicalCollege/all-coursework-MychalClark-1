﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Ability
    {
        private string _name;
        public  Ability(string name) 
        { _name = name;  }
       

        public string Name { get => _name; set => _name = value; }

      
    }
}
