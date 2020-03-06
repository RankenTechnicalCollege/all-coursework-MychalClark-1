using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT1
{
    class ShortTermLoan : ILoan
    { private string _name;
        private double _balance;
        
        public string Name => _name;

        public string Type => "short";

        public double Balance => _balance;

       public ShortTermLoan(string name, double balance) { _name = name; _balance = balance; }
        public double ApplyInterest()
        {
            double interest = (_balance * 0.10) + _balance;
            _balance = interest;
            return _balance;
        }

        public double MakePayment()
        {
            
            double balance = _balance - 450;
            _balance = balance;
            return _balance;
          
        }
    }
}
