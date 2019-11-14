using System;

namespace p03_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall;
            double price;

            if (numberOfPeople <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (numberOfPeople <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (numberOfPeople <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package.Equals("Normal"))
            {
                price += 500;
                price -= price * 5 / 100;
            }
            else if (package.Equals("Gold"))
            {
                price += 750;
                price -= price * 10 / 100;
            }
            else if (package.Equals("Platinum"))
            {
                price += 1000;
                price -= price * 15 / 100;
            }

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {(price / numberOfPeople):F2}$");
        }
    }
}
