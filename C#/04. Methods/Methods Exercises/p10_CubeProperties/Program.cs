using System;

namespace p10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            Console.WriteLine($"{CalculateCubeProperty(side, property):F2}");
        }

        static double CalculateCubeProperty(double side, string property)
        {
            switch (property)
            {
                case "face":
                    double face = Math.Sqrt(2 * Math.Pow(side, 2));
                    return face;
                case "space":
                    double space = Math.Sqrt(3 * Math.Pow(side, 2));
                    return space;
                case "volume":
                    double volume = Math.Pow(side, 3);
                    return volume;
                case "area":
                    double area = 6 * Math.Pow(side, 2);
                    return area;
            }

            return -1;
        }
    }
}
