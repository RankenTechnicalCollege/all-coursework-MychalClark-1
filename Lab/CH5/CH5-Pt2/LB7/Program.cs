using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> danSales = new List<double>();
            List<double> edSales = new List<double>();
            List<double> franSales = new List<double>();
        
            int info = 0;
            for (int i = 0; 0 <= info; i++) {
                Console.WriteLine("Who Made The Sale");
                string person = Console.ReadLine();

                if (person == "d" || person == "e" || person == "f" || person == "z") {
                 if (person == "d") { Console.WriteLine("How Much was the sale"); double dan = Convert.ToDouble(Console.ReadLine()); danSales.Add(dan); info++; }
                    else if (person == "e") { Console.WriteLine("How Much was the sale"); double ed = Convert.ToDouble(Console.ReadLine()); edSales.Add(ed); info++; }
                    else if (person == "f") { Console.WriteLine("How Much was the sale"); double fran = Convert.ToDouble(Console.ReadLine()); franSales.Add(fran); info++; }
                    else if (person == "z") {
                        Console.WriteLine($"Danielle Sales: {danSales.Sum():C2}");
                        Console.WriteLine($"Edward Sales: {edSales.Sum():C2}");
                        Console.WriteLine($"Francis Sales: {franSales.Sum():C2}");
                        double total = edSales.Sum() + danSales.Sum() + franSales.Sum();
                        Console.WriteLine("");
                        Console.WriteLine($"Grand Total: {total:C2}");
                        

                        if (edSales.Sum() > danSales.Sum() && edSales.Sum() > franSales.Sum()) { Console.WriteLine("Edward Has the Most Sells..."); }
                        if (danSales.Sum() > edSales.Sum() && danSales.Sum() > franSales.Sum()) { Console.WriteLine("Dannielle Has the Most Sells..."); }
                        if (franSales.Sum() > danSales.Sum() && franSales.Sum() > edSales.Sum()) { Console.WriteLine("Francis Has the Most Sells..."); }
                        break;
                    }
                    
                }
                else { Console.WriteLine("Invalid Initial"); }
            }
        }
    }
}
