using System;

namespace p04_VariableInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();

            int decValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(decValue);
        }
    }
}
