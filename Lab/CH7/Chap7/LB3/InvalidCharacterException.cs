using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
   public class InvalidCharacterException:ArgumentException
    {
        public InvalidCharacterException() : base("Invalid Chars") { }
    }
}
