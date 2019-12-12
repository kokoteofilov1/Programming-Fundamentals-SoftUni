using System;
using System.Numerics;

namespace p14_FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(n);

            Console.WriteLine(CountTrailingZeroes(factorial));
        }

        static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CountTrailingZeroes(BigInteger factorial)
        {
            BigInteger currentDigit = factorial % 10;
            int trailingZeroCounter = 0;
            while (currentDigit == 0)
            {
                trailingZeroCounter++;
                factorial /= 10;
                currentDigit = factorial % 10;
            }

            return trailingZeroCounter;
        }
    }
}
