using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:  "); string name =Console.ReadLine();
            Console.Write("Street Address:  "); string addy = Console.ReadLine();
            Console.Write("City:  "); string city = Console.ReadLine();
            Console.Write("State:  "); string state = Console.ReadLine();
            Console.Write("Zip:  "); string zip =Console.ReadLine();
            Console.Write("How Many T-Shirts did you want to order?  "); int shirtOrder = Convert.ToInt32(Console.ReadLine());

            Convert.ToDouble(shirtOrder);
            double totalPrice = shirtOrder * 14.99;
            double salesTax = totalPrice * 0.08;
            double amountDue = salesTax + totalPrice;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Receipt for:");
            Console.WriteLine($"{name}");
            Console.WriteLine($"{addy}");
            Console.WriteLine($"{city}, {state} {zip}");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"{shirtOrder} T-Shirts ordered @ $14.99 each");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"Total:        {totalPrice:C}");
            Console.WriteLine($"Tax:          {salesTax:C}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Due:          {amountDue:C}");

        }
    }
}
