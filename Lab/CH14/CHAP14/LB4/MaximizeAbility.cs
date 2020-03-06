using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace LB4
{
    class MaximizeAbility : IAbility
    {
        public void Execute(PokemonForm form)
        {
            form.WindowState = FormWindowState.Maximized;


            return ;
        }
        

        public string GetName()
        {
            string me = "MaximizeAbility";
            return me ;
        }
    }
}
