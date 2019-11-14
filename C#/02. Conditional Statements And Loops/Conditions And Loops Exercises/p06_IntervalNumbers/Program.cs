using System;

namespace p06_IntervalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int startIndex = Math.Min(a, b);
            int endIndex = Math.Max(a, b);

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
