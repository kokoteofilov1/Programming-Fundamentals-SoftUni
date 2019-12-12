using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            PrintListOfIntegers(FindPrimesInRange(start, end));
        }

        static bool IsPrime(long n)
        {
            n = Math.Abs(n);

            if (n == 0 || n == 1)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static void PrintListOfIntegers(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list));
        }
    }
}
