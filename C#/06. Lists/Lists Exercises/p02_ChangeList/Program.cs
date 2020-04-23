using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] input;
            string command;
            while (true)
            {
                input = Console.ReadLine().Split(' ');

                command = input[0];

                if (command == "Delete")
                {
                    list.RemoveAll(x => x == int.Parse(input[1]));
                }
                else if (command == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (command == "Odd")
                {
                    Console.WriteLine(String.Join(" ", list.FindAll(x => x % 2 == 1)));
                    return;
                }
                else if (command == "Even")
                {
                    Console.WriteLine(String.Join(" ", list.FindAll(x => x % 2 == 0)));
                    return;
                }
            }
        }
    }
}
