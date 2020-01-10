using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Miles");
            double miles = Convert.ToDouble(Console.ReadLine());

            const double KM_PER_MILE = 1.6;

           double milesHere = miles * KM_PER_MILE;

            Console.WriteLine("{0} miles is {1} kilometers", miles, milesHere);

            
            
        }
    }
}
