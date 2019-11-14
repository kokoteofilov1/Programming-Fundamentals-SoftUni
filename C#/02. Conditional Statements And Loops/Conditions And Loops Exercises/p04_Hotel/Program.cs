using System;
using System.Diagnostics;

namespace p04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = -1;
            double doublePrice = -1;
            double suitePrice = -1;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * nights;
                    doublePrice = 65 * nights;
                    suitePrice = 75 * nights;
                    break;
                case "June":
                case "September":
                    studioPrice = 60 * nights;
                    doublePrice = 72 * nights;
                    suitePrice = 82 * nights;
                    break;
                case "July":
                case "August":
                    studioPrice = 68 * nights;
                    doublePrice = 77 * nights;
                    suitePrice = 89 * nights;
                    break;
            }

            if (nights > 7 && (month.Equals("May") || month.Equals("October")))
            {
                studioPrice -= studioPrice * 5 / 100;
            }
            if (nights > 14 && (month.Equals("June") || month.Equals("September")))
            {
                doublePrice -= doublePrice * 10 / 100;
            }
            if (nights > 14 && (month.Equals("July") || month.Equals("August") || month.Equals("December")))
            {
                suitePrice -= suitePrice * 15 / 100;
            }
            if (nights > 7 && (month.Equals("September") || month.Equals("October")))
            {
                if (month.Equals("September"))
                {
                    studioPrice = 60 * (nights - 1);
                }
                else
                {
                    studioPrice = 50 * (nights - 1);
                }
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
