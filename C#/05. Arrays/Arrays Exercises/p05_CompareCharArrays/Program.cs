using System;
using System.Linq;

namespace p05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(n => char.Parse(n)).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(n => char.Parse(n)).ToArray();

            //compare arrays until the length of the shorter one is reached

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(String.Join("", firstArray));
                    Console.WriteLine(String.Join("", secondArray));
                    return;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(String.Join("", secondArray));
                    Console.WriteLine(String.Join("", firstArray));
                    return;
                }
            }

            //if arrays are the same up to the length of the shorter one, print the shorter one first

            if (Math.Min(firstArray.Length, secondArray.Length) == firstArray.Length)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
