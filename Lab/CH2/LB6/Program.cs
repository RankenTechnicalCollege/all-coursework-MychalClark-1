using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grade 1");
            double score1  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade 2");
            double score2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade 3");
            double score3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade 4");
            double score4 = Convert.ToDouble(Console.ReadLine());

            double average = (score1 + score2 + score3 + score4) / 4;

            Console.WriteLine(average);


        }
    }
}
