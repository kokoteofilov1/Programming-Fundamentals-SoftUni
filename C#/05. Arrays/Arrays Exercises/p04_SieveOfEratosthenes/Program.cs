using System;

namespace p04_SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] array = new bool[n + 1];

            //initialize values for elements in array
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = true;
            }

            //sieve the array
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    int j = 2;
                    while (j * i < array.Length)
                    {
                        array[i * j] = false;
                        j++;
                    }
                }
            }

            //print the prime numbers from the array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
