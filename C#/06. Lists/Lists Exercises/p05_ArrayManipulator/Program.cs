using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "print")
            {
                string[] commandArgs = command.Split(' ');
                string commandType = commandArgs[0];


                if (commandType == "add")
                {
                    int index = int.Parse(commandArgs[1]);
                    list.Insert(index, int.Parse(commandArgs[2]));
                }
                else if (commandType == "addMany")
                {
                    int index = int.Parse(commandArgs[1]);
                    for (int i = 2; i < commandArgs.Length; i++)
                    {
                        list.Insert(index, int.Parse(commandArgs[i]));
                        index++;
                    }
                }
                else if (commandType == "contains")
                {
                    int num = int.Parse(commandArgs[1]);
                    if (list.Contains(num))
                    {
                        Console.WriteLine(list.IndexOf(num));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commandType == "remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    list.RemoveAt(index);
                }
                else if (commandType == "shift")
                {
                    int shiftValue = int.Parse(commandArgs[1]) % list.Count;
                    var result = list.GetRange(shiftValue, list.Count - shiftValue);
                    result.AddRange(list.GetRange(0, shiftValue));
                    list = result;
                }
                else if (commandType == "sumPairs")
                {
                    for (int i = 1; i < list.Count; i++)
                    {
                        list[i] += list[i - 1];
                        list.RemoveAt(i - 1);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong commandType! Try again:");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", list)}]");
        }
    }
}
