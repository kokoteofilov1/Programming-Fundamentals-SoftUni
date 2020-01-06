using System;
using System.Linq;

namespace p05_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] arr = input.Split(' ').Select(n => double.Parse(n)).ToArray();

            foreach (double dec in arr)
            {
                Console.WriteLine($"{dec} => {Math.Round(dec, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
