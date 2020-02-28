using System;
using System.Linq;

namespace p06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceList = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int jewelsPrice = priceList[0];
            int goldPrice = priceList[1];

            long lootPrice = 0;
            long heistExpenses = 0;

            string input = Console.ReadLine();
            while (input != "Jail Time")
            {
                char[] loot = input.Split(' ')[0].ToCharArray();

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        lootPrice += jewelsPrice;
                    }
                    else if (loot[i] == '$')
                    {
                        lootPrice += goldPrice;
                    }
                }

                int expenses = int.Parse(input.Split(' ')[1]);

                heistExpenses += expenses;

                input = Console.ReadLine();
            }

            long difference = Math.Abs(lootPrice - heistExpenses);

            if (lootPrice >= heistExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {difference}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {difference}.");
            }
        }
    }
}
