using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    class AccountDisabledException: Exception
    {public AccountDisabledException():base("Account Disabled") { }
    }
}
