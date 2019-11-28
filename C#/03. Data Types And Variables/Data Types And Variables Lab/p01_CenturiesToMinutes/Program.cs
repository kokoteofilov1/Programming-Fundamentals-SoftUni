﻿using System;

namespace p01_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            uint years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
