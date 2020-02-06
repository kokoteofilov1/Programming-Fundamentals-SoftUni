using System;
using System.Linq;

namespace p11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
