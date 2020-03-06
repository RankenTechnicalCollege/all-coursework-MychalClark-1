using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace LB4
{
    class DayModeAbility : IAbility
    {
        public void Execute(PokemonForm form)
        {
            form.BackColor = Color.Yellow;
            return;
        }

        public string GetName()
        {
            string me = "DayModeAbility";
            return me;
        }
    }
}
