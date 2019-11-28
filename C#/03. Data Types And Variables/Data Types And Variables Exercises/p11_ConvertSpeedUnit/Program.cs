using System;

namespace p11_ConvertSpeedUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            int hoursInput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());
            int secondsInput = int.Parse(Console.ReadLine());

            int totalSeconds = hoursInput * 3600 + minutesInput * 60 + secondsInput;

            float metersPerSecond = (float)distanceInMeters / totalSeconds;
            float kilometersPerHour = metersPerSecond * 3.6f;
            float milesPerHour = kilometersPerHour * 0.6215f;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
