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

            string[] productInfo = Console.ReadLine().Split(' ');
            while (productInfo[0] != "done")
            {
                string productName = productInfo[0];
                long requestedQuantity = long.Parse(productInfo[1]);
                int productIndex = Array.IndexOf(products, productName);

                if (productIndex >= quantities.Length || quantities[productIndex] < requestedQuantity)
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else
                {
                    Console.WriteLine($"{productName} x {requestedQuantity} costs {prices[productIndex] * requestedQuantity:f2}");
                    quantities[productIndex] -= requestedQuantity;
                }

                productInfo = Console.ReadLine().Split(' ');
            }
        }
    }
}