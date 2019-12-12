﻿using System;

namespace p07_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * number;
            }

            return result;
        }
    }
}
