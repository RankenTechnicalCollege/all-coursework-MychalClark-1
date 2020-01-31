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
            List<double> numList = new List<double>();
            Console.WriteLine("Enter Test scores 0-100, and 999 to stop");
            Console.Write("Please Enter A Test Score:");
            double Fscore = Convert.ToInt32(Console.ReadLine());
            if (Fscore < 0 || Fscore > 100) { Console.WriteLine("You Broke The App. CoNgRatUlAtIoNs"); Environment.Exit(0); }

            numList.Add(Fscore);


               
            for (int i = 0; i < numList.Count; i++)
            {
                Console.Write("Please Enter A Test Score:");
                double score = Convert.ToDouble(Console.ReadLine());
                if (score == 999) {
                    Console.WriteLine("");
                    Console.WriteLine($"Number Of Scores:{numList.Count}");
                    Console.WriteLine($"Sum Of Test Scores: {numList.Sum()}");
                    Console.WriteLine($"Average Of Test Scores: {numList.Average()}");
                    Console.WriteLine($"Lowest Test Score: {numList.Min()}");
                    Console.WriteLine($"Highest Test Score: {numList.Max()}"); 
                    break; }
                else if (score < 0 || score > 100) { Console.WriteLine("Invalid Score"); i--; continue; }
                else { numList.Add(score); }
                
            }

            
        }
    }
}
