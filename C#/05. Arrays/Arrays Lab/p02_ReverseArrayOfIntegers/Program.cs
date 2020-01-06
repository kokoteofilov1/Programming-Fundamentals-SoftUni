using System;

namespace p02_ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numsArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                numsArray[i] = int.Parse(Console.ReadLine());
            }

            ReverseArray(numsArray);
        }

        static void ReverseArray(int[] numsArray)
        {
            int start = 0;
            int end = numsArray.Length - 1;

            while (start < end)
            {
                int temp = numsArray[start];
                numsArray[start] = numsArray[end];
                numsArray[end] = temp;

                start++;
                end--;
            }

            foreach (int num in numsArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
