﻿using System;
using System.Numerics;

namespace p10_CenturiesToNanoS
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            uint years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            long hours = days * 24;
            ulong minutes = (ulong)hours * 60;
            BigInteger seconds = (BigInteger)minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;


            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes}" +
                              $" minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds" +
                              $" = {nanoseconds} nanoseconds");
        }
    }
}