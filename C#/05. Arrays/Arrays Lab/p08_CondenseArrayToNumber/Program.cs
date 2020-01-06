using System;
using System.Linq;

namespace p08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] array = input.Split(' ').Select(n => int.Parse(n)).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine($"{array[0]} is already condensed to number");
                return;
            }

            while (array.Length > 1)
            {
                int[] condensed = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                }

                array = condensed;
            }

            Console.WriteLine(array[0]);
        }
    }
}
