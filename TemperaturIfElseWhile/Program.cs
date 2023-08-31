using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("Skriv tempen idiot");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int tempratur))
            {
                if (tempratur > 0)
                {
                    Console.WriteLine("tempratur er pluss");
                }
                else if (tempratur < 0)
                {
                    Console.WriteLine("tempratur er minus");
                }
                else
                {
                    Console.WriteLine("tempratur er null");
                }
            }
            else
            {
                Console.WriteLine("ugyldig data");
            }
        }
        }
    }
}
