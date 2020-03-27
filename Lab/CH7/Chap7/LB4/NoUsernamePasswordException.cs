using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class NoUsernamePasswordException :Exception
    {
        public NoUsernamePasswordException(): base("You must enter a username and Password")
        {

        }
    }
}
