using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Enter a Word");
            string name = Console.ReadLine();
            string firstLetter = name.Substring(0, 1);

            

            Console.WriteLine($"{name.Substring(1) + firstLetter}ay");
        }
    }
}
