using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type A Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type A Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type A Number");
           double num3 =Convert.ToDouble(Console.ReadLine());

            double avg = (num3 + num2 + num1) / 3;

            Console.WriteLine($"Your average is {avg}");
        }
    }
}
