using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace p07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int specialNumber = numbers[0];
            int power = numbers[1];

            while (list.Contains(specialNumber))
            {
                int leftRange = Math.Max(0, list.IndexOf(specialNumber) - power);
                int rightRange = Math.Min(list.Count - 1, list.IndexOf(specialNumber) + power);

                for (int i = rightRange; i >= leftRange; i--)
                {
                    list.RemoveAt(i);
                }
            }

            int sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
