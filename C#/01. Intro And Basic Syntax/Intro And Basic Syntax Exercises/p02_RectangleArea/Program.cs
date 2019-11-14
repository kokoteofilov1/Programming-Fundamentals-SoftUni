using System;

namespace p02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            Console.WriteLine($"{area:F2}");
        }
    }
}
