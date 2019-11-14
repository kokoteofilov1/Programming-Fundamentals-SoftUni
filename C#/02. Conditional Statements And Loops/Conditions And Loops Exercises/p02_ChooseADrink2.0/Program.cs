using System;

namespace p02_ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price;

            switch (profession)
            {
                case "Athlete":
                    price = amount * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = amount * 1.00;
                    break;
                case "SoftUni Student":
                    price = amount * 1.70;
                    break;
                default:
                    price = amount * 1.20;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
