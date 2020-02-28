using System;
using System.Linq;

namespace p02_ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "Reverse")
                {
                    Reverse(array);
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    Replace(array, Convert.ToInt32(command[1]), command[2]);
                }
                else
                {
                    Console.WriteLine("Wrong command!");
                    return;
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }

        static void Reverse(string[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                string temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        static void Replace(string[] array, int index, string replacement)
        {
            array[index] = replacement;
        }
    }
}
