using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    class MinimizeAbility : IAbility
    {
        public void Execute(PokemonForm form)
        {
            form.WindowState = FormWindowState.Minimized;
            return;
        }

        public string GetName()
        {
            string me = "MinimizeAbility";
            return me;
        }
    }
}
