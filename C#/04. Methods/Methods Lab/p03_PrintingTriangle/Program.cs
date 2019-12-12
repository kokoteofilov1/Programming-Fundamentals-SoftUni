﻿using System;

namespace p03_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
