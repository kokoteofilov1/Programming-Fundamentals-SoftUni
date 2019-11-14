using System;

namespace p10_MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplicator = int.Parse(Console.ReadLine());

            if (multiplicator > 10)
            {
                Console.WriteLine($"{num} X {multiplicator} = {num * multiplicator}");
            }
            else
            {
                for (int i = multiplicator; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
        }
    }
}
