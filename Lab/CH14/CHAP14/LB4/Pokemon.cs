using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    class Pokemon
    {
        private string _name;
        private System.Drawing.Image _image;
        private IAbility _ability;


        public Pokemon(string name, System.Drawing.Image image, IAbility ability)
        {
            _name = name;
            _image = image;

            
            _ability = ability;
        }

        public string Name { get => _name; }
        public System.Drawing.Image Image { get => _image; }
        public IAbility Ability { get => _ability; }
    }
}
