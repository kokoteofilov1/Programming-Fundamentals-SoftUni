using System;
using System.Linq;

namespace p09_ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] array = input.Split(' ').Select(n => int.Parse(n)).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine("{ " + array[0] + " }");

            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{ " + array[array.Length / 2 - 1]
                                       + ", " + array[array.Length / 2]
                                       + " }");
            }
            else
            {
                Console.WriteLine("{ " + array[array.Length / 2 - 1]
                                       + ", " + array[array.Length / 2]
                                       + ", " + array[array.Length / 2 + 1]
                                       + " }");
            }
        }
    }
}
