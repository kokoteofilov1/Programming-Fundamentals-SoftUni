using System;

namespace p11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            Console.WriteLine($"{GeometryCalculator(figure):F2}");
        }

        static double GeometryCalculator(string figure)
        {
            double area = 0;
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = (side * height) / 2;
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = Math.Pow(side, 2);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = width * height;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * Math.Pow(radius, 2);
            }
            else
            {
                area = -1;
            }

            return area;
        }
    }
}
