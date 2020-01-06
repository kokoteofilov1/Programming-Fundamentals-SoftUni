using System;

namespace p03_LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];

            sequence[0] = 1;

            for (int i = 0; i <= sequence.Length - 1; i++)
            {
                long sum = 0;

                int temp = i - k;
                if (temp < 0)
                {
                    temp = 0;
                }
                for (int j = temp; j < temp + k; j++)
                {
                    sum += sequence[j];
                }

                sequence[i] = sum;
            }

            foreach (long num in sequence)
            {
                Console.Write(num + " ");
            }
        }
    }
}
