using System;

namespace p04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energyContent = int.Parse(Console.ReadLine());
            double sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:\n{energyContent * volume / 100}kcal, {sugarContent * volume / 100}g sugars");
        }
    }
}
