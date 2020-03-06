using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace LB4
{
    class NightModeAbility : IAbility
    {
        public void Execute(PokemonForm form)
        {
            form.BackColor = Color.Black;
            return;
        }

        public string GetName()
        {
            string me = "NightModeAbility";
            return me;
        }
    }
}
