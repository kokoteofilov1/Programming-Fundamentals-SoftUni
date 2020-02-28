using System;
using System.Linq;

namespace p09_JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int sum = 0;
            int currentNumber = array[0];
            int currentIndex = 0;
            while (true)
            {
                sum += currentNumber;

                if ((array.Length - 1) - currentIndex >= currentNumber)
                {
                    currentIndex += currentNumber;
                    currentNumber = array[currentNumber];
                }
                else if (currentIndex > currentNumber)
                {
                    int temp = currentIndex;
                    currentIndex -= currentNumber;
                    currentNumber = array[temp - currentNumber];

                }
                else
                {
                    Console.WriteLine(sum);
                    return;
                }
            }
        }
    }
}
