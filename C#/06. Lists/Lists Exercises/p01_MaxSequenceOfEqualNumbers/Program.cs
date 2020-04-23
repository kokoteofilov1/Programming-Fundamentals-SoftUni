using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxSequenceStart = 0;
            int maxSequenceLength = 1;

            int currentSequenceStart = 0;
            int currentSequenceLength = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[currentSequenceStart])
                {
                    currentSequenceLength++;
                }
                else
                {
                    currentSequenceStart = i;
                    currentSequenceLength = 1;
                }

                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    maxSequenceStart = currentSequenceStart;
                }
            }

            Console.WriteLine(String.Join(" ", list.GetRange(maxSequenceStart, maxSequenceLength)));
        }
    }
}
