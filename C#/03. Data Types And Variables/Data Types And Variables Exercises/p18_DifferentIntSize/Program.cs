using System;
using System.Runtime.CompilerServices;

namespace p18_DifferentIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N > long.MaxValue)
            {
                Console.WriteLine($"{N} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{N} can fit in:");

                try
                {
                    byte.par
                }
            }
        }
    }
}
