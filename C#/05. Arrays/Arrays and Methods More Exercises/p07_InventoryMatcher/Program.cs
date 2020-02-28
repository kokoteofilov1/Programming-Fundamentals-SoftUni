using System;
using System.Linq;

namespace p07_InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();
            double[] prices = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();

            string product = Console.ReadLine();
            while (product != "done")
            {
                int productIndex = Array.IndexOf(products, product);

                Console.WriteLine($"{product} costs: {prices[productIndex]:f2}; Available quantity: {quantities[productIndex]}");

                product = Console.ReadLine();
            }
        }
    }
}