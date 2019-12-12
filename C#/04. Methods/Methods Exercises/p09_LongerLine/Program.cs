using System;

namespace p09_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4,
            double y4)
        {
            double lineOneLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double lineTwoLength = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if (lineOneLength >= lineTwoLength)
            {
                PrintClosestPointFirst(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPointFirst(x3, y3, x4, y4);
            }
        }

        static void PrintClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            double pointOneDistanceFromCenter = Math.Abs(x1) + Math.Abs(x2);
            double pointTwoDistanceFromCenter = Math.Abs(x2) + Math.Abs(y2);

            if (pointOneDistanceFromCenter <= pointTwoDistanceFromCenter)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
