using System;
using System.Linq;

namespace p03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split(' ').Select(n => int.Parse(n)).ToArray();

            int k = array.Length / 4;

            int mid = array.Length / 2;

            int[] firstHalf = array.Take(mid).ToArray();
            int[] secondHalf = array.Skip(mid).ToArray();

            array = new int[mid];
            for (int i = 0; i < k; i++)
            {
                int temp1 = firstHalf[mid - 1 - i - k] + firstHalf[mid - k + i];
                int temp2 = secondHalf[mid - 1 - i] + secondHalf[i];

                array[i] = temp1;
                array[i + mid / 2] = temp2;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
