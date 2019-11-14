using System;

namespace p11_5DifferentNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //check if operations possible
            if (a > b || !(b - a >= 4))
            {
                Console.WriteLine("No");
                return;
            }

            //declare array
            int[] array = new int[5];

            //initialize array
            for (int i = 0; i < 5; i++)
            {
                array[i] = a;
                a++;
            }

            int lastUnchangedIndex = 4;
            while (true)
            {
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                if (array[lastUnchangedIndex] < b)
                {
                    array[lastUnchangedIndex]++;
                }
                else
                {
                    b--;
                    try
                    {
                        lastUnchangedIndex--;
                        array[lastUnchangedIndex]++;
                    }
                    catch (Exception e)
                    {
                        return;
                    }
                }
            }
        }
    }
}
