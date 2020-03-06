using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT1
{
    class LongTermLoan : ILoan
    {
        private string _name;
        private double _balance;

        public string Name => _name;

        public string Type => "long";

        public double Balance => _balance;
       public LongTermLoan(string name, double balance) { _name = name; _balance = balance; }
        public double ApplyInterest()
        {
            double interest = (_balance * 0.05) + _balance;
            _balance = interest;
            return _balance;
            
        }

        public double MakePayment()
        {
           double balance = _balance - 200;
            _balance = balance;
            return _balance;
        }
    }
}
