using System;
using System.Linq;

namespace p08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int maxNumber = array[0];
            int maxCount = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxNumber = array[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
