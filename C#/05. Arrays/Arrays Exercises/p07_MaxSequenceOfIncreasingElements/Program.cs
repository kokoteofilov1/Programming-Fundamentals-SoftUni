using System;
using System.Linq;

namespace p06_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int bestStartingPosition = 0;
            int bestLength = 1;

            //checks the array for sequences of equal elements

            int currentStartingPosition = 0;
            int currentLength = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (currentLength == 1)
                    {
                        currentStartingPosition = i - 1;
                    }
                    currentLength++;

                    //when a sequence becomes larger than the current best, the current best is updated

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStartingPosition = currentStartingPosition;
                    }
                }
                //resets the current length and starting position when a sequence ends
                else
                {

                    currentLength = 1;
                    currentStartingPosition = i;
                }
            }

            var longestSequence = array.Skip(bestStartingPosition).Take(bestLength);

            Console.WriteLine(String.Join(" ", longestSequence));
        }
    }
}
