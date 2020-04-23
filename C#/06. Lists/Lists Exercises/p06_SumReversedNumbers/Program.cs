using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            foreach (int num in list)
            {
                int reverse = 0;
                int temp = num;
                while (temp != 0)
                {
                    reverse = reverse * 10 + temp % 10;
                    temp /= 10;
                }

                sum += reverse;
            }

            Console.WriteLine(sum);
        }
    }
}
