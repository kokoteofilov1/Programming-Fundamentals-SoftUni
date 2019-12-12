using System;

namespace p08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double pointOneDistanceFromCenter = Math.Abs(x1) + Math.Abs(x2);
            double pointTwoDistanceFromCenter = Math.Abs(x2) + Math.Abs(y2);

            if (pointOneDistanceFromCenter <= pointTwoDistanceFromCenter)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
