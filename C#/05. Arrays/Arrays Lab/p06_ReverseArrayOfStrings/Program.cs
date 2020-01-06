using System;
using System.Linq;

namespace p06_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] stringArray = input.Split(' ').ToArray();

            ReverseArray(stringArray);
        }

        static void ReverseArray(string[] stringArray)
        {
            int start = 0;
            int end = stringArray.Length - 1;

            while (start < end)
            {
                string temp = stringArray[start];
                stringArray[start] = stringArray[end];
                stringArray[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine(String.Join(" ", stringArray));
        }
    }
}
