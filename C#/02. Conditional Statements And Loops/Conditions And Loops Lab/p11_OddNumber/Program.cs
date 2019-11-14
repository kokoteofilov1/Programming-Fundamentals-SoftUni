using System;

namespace p11_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);

                if (num % 2 != 0)
                {
                    Console.WriteLine($"The number is: {num}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
