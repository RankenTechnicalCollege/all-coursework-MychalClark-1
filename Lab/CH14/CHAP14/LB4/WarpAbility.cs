using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    class WarpAbility : IAbility
    {
        public void Execute(PokemonForm form)
        { Random rand = new Random();
            int randomVert = rand.Next(1000);
            int randomHor = rand.Next(1000);
            form.SetDesktopLocation(randomVert, randomHor);
            return;
            

        }

        public string GetName()
        {
            string me = "WarpAbility";
            return me;
        }
    }
}
