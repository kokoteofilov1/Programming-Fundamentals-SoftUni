using System;
using System.Linq;

namespace p02_ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
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
                    int index = Convert.ToInt32(command[1]);
                    string replacement = command[2];

                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        Replace(array, index, replacement);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ').ToArray();
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
