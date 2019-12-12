using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            PrintReversedNumber(num);
        }

        static void PrintReversedNumber(string num)
        {
            string reversed = new string(num.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
