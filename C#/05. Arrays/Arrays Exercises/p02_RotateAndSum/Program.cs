using System;
using System.Linq;

namespace p02_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalRotations = int.Parse(Console.ReadLine());

            int[] array = input.Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] sum = new int[array.Length];

            for (int rotation = 1; rotation <= totalRotations; rotation++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    sum[(j + rotation) % array.Length] += array[j];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
