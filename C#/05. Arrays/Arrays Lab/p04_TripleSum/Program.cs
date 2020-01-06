using System;
using System.Linq;

namespace p04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] arr = input.Split(' ').Select(n => int.Parse(n)).ToArray();

            bool tripleSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] == arr[k])
                        {
                            tripleSum = true;
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                        }
                    }
                }
            }

            if (!tripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
