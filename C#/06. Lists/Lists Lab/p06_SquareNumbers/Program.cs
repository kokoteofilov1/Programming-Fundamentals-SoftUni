using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                double sqrt = Math.Sqrt(list[i]);
                if (sqrt != (int)sqrt)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            list.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
