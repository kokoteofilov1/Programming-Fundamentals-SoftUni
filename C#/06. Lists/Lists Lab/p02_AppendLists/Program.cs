using System;
using System.Collections.Generic;

namespace p02_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            Array.Reverse(input);

            List<string> list = new List<string>();
            foreach (string token in input)
            {
                foreach (string num in token.Split(' '))
                {
                    if (!String.IsNullOrWhiteSpace(num))
                    {
                        list.Add(num);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
