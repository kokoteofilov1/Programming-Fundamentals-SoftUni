using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();

            for (int i = 0; i < input.Count; i++)
            {
                int currentNum = input[i];

                int count = 1;
                while (i < input.Count - 1 && input[i + 1] == currentNum)
                {
                    count++;
                    i++;
                }

                Console.WriteLine($"{currentNum} -> {count}");
            }
        }
    }
}
