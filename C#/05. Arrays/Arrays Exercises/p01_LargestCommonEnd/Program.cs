using System;
using System.Linq;

namespace p01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] array1 = input1.Split(' ').ToArray();
            string[] array2 = input2.Split(' ').ToArray();

            int minArrayLength = Math.Min(array1.Length, array2.Length);

            int leftCommonEnd = 0;

            for (int i = 0; i < minArrayLength; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCommonEnd++;
                }
            }

            int rightCommonEnd = 0;

            for (int i = 0; i < minArrayLength; i++)
            {
                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                {
                    rightCommonEnd++;
                }
            }

            Console.WriteLine(Math.Max(leftCommonEnd, rightCommonEnd));
        }
    }
}
