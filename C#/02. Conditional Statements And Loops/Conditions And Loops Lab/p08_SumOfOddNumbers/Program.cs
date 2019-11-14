using System;
using System.Diagnostics.Tracing;

namespace p08_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            int num = 1;
            while (counter < count)
            {
                sum += num;
                Console.WriteLine(num);
                num += 2;

                counter++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
