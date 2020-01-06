using System;
using System.Linq;
using System.Transactions;

namespace p07_SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int[] arr1 = input1.Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] arr2 = input2.Split(' ').Select(n => int.Parse(n)).ToArray();

            int sum;

            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                sum = arr1[i % arr1.Length] + arr2[i % arr2.Length];

                Console.Write(sum + " ");
            }
        }
    }
}
