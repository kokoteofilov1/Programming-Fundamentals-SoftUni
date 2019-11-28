using System;

namespace p06_StringsAndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;

            string output = (string)obj;

            Console.WriteLine(output);
        }
    }
}
