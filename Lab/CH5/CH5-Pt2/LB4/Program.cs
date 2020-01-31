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
            Console.WriteLine("How Many Rows should the table have?");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How Many Columns should the table have?");
            int columns = Convert.ToInt32(Console.ReadLine());

            
            for(int i=0; i<=columns; i++)
            {//Count Row
                if (i == 0) { Console.Write($"{"",5}|"); }
                else
                {
                    Console.Write($"{i,5}|");
                }
                

            }
            Console.WriteLine("");
            for (int i = 0; i <= columns; i++)
            {//Display Line
                Console.Write("------");

            }

            Console.WriteLine("");

            for (int idx = 0; idx <= rows; idx++)
            {//Count Columns
                if(idx == 0)
                {
                  
                }
                else {
                    Console.Write($"{idx,5}|");
                    for (int i = 1; i <= columns; i++) { Console.Write($"{idx * i,5}|"); }
                    Console.WriteLine(""); }

            }
        }
    }
}
