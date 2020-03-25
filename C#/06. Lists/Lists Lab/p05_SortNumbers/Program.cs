using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            list.Sort();

            Console.WriteLine(String.Join(" <= ", list));
        }
    }
}
