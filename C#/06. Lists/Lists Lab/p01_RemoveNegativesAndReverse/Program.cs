using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.RemoveAll(n => n < 0);
            list.Reverse();

            if (list.Count > 0)
            {
                Console.WriteLine(String.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
