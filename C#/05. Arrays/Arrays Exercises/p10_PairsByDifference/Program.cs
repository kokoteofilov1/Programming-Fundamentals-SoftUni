using System;
using System.Linq;

namespace p10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int pairsCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) == difference)
                    {
                        pairsCount++;
                    }
                }
            }

            Console.WriteLine(pairsCount);
        }
    }
}
