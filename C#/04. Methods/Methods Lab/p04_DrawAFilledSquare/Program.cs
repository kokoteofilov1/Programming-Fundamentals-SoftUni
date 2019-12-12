using System;

namespace p04_DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintOutsideRows(n);
            Console.WriteLine();
            PrintMiddleRows(n);
            PrintOutsideRows(n);
        }

        static void PrintOutsideRows(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("-");
            }
        }

        static void PrintMiddleRows(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
