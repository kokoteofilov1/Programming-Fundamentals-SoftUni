using System;
using System.Linq;

namespace p05_PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int ingredientLength = int.Parse(Console.ReadLine());

            int ingredientCounter = 0;
            for (int i = 0; i < ingredients.Length && ingredientCounter < 10; i++)
            {
                if (ingredients[i].Length == ingredientLength)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    ingredientCounter++;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredientCounter} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", ingredients.Where(n => n.Length == ingredientLength).Take(10))}.");
        }
    }
}
