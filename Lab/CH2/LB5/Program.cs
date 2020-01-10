using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PERCENT_RAISE = 0.4;
            //First Person
            Console.WriteLine("Enter Name 1");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            double sal1 = Convert.ToDouble(Console.ReadLine());
             //second pErson
            Console.WriteLine("Enter Name 2");
            string name2 = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            double sal2 = Convert.ToDouble(Console.ReadLine());
            //Third Person
            Console.WriteLine("Enter Name 3");
            string name3 = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            double sal3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine("| Year       | {0,-6}     | {1,-6}     | {2,-6}", name1 , name2, name3);
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine("| 2019       | {0,-6:C}   | {1,-6:C}   | {2,-6:C}", sal1 , sal2, sal3);
            Console.WriteLine("| 2020       | {0,-6:C}   | {1,-6:C}   | {2,-6:C}", sal1+=sal1 *.04, sal2+=sal2 * .04, sal3+=sal3 * .04);
            Console.WriteLine("| 2021       | {0,-6:C}   | {1,-6:C}   | {2,-6:C}", sal1 += sal1 * .04, sal2 += sal2 * .04, sal3 += sal3 * .04);






            Console.WriteLine("+------------+------------+------------+------------+");
        }
    }
}
