using System;
using System.Linq;

namespace p04_GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int num = int.Parse(Console.ReadLine());

            bool isFound = false;
            int lastPosition = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    isFound = true;
                    lastPosition = i;
                }
            }

            if (isFound)
            {
                long sum = 0;
                for (int i = 0; i < lastPosition; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
