using System;

namespace p05_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            int fib = 1;
            int lastFib = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    lastFib = 1;
                }
                else
                {
                    int temp = fib;
                    fib = fib + lastFib;
                    lastFib = temp;
                }
            }

            return fib;
        }
    }
}
