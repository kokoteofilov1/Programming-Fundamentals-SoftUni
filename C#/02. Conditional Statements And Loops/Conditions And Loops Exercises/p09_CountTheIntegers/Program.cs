using System;

namespace p09_CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
