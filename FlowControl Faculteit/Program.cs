using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl_Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in:");

            double num = Int32.Parse(Console.ReadLine());

            double k = 1;
            for (double i = 1; i < num; i++)
            {
               
                Console.WriteLine($"er is een cijfer {i}");
                k = k * i;
            }
            Console.WriteLine($" en de totaal geeft: {k}");
        }
    }
}
