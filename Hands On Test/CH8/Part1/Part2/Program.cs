using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> purchase = new List<double>();
            Console.WriteLine("Enter The Prices of your items, And enter 0 to stop");
            int up = 0;
            for (int i = -1; i < purchase.Count; i++)
            {
                up++;


                if (up < 10) { Console.Write($"0{up}: "); }
                else { Console.Write($"{up}: "); }

                double enter = Convert.ToDouble(Console.ReadLine());
                if (enter < 0) { Console.WriteLine("INVALID PRICE"); i--; }
                if (enter == 0) { break; }
                if(enter > 0) { purchase.Add(enter); }
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Items Purchased:{purchase.Count}");
            Console.WriteLine($"Average Item Price:{purchase.Average():C}");
            Console.WriteLine($"Subtotal Price:{purchase.Sum():C}");
            double tax = purchase.Sum() * 0.08;
            Console.WriteLine($"Tax:{tax:C}");
            Console.WriteLine($"Total:{tax + purchase.Sum():C}");

        }
    }
}
