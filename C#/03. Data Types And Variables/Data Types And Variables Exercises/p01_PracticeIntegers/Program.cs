﻿using System;
using System.Runtime.CompilerServices;

namespace p01_PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = sbyte.Parse(Console.ReadLine());
            byte num2 = byte.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            ushort num4 = ushort.Parse(Console.ReadLine());
            uint num5 = uint.Parse(Console.ReadLine());
            long num6 = long.Parse(Console.ReadLine());
            ulong num7 = ulong.Parse(Console.ReadLine());

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }
    }
}
