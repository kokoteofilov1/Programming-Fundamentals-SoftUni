using System;

namespace p02_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = r * r * Math.PI;

            Console.WriteLine($"{area:f12}");
        }
    }
}
