using System;
using System.Threading;

namespace p05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool output = Convert.ToBoolean(input);

            if (output)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
