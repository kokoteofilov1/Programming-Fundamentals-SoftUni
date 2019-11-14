﻿using System;

namespace p08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientAmount = int.Parse(Console.ReadLine());

            int calories = 0;

            string ingredient;
            for (int i = 0; i < ingredientAmount; i++)
            {
                ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
