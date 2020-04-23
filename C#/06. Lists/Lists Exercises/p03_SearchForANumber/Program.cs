using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] manipulations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            list = list.Take(manipulations[0]).ToList();
            list.RemoveRange(0, manipulations[1]);

            if (list.Contains(manipulations[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
