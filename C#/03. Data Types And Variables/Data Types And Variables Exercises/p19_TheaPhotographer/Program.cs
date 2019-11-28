using System;

namespace p19_TheaPhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int filteredPictures = (int)Math.Ceiling(((double)pictures * (double)filterFactor) / 100);

            long time = 0;
            time += pictures * (long)filterTime;
            time += filteredPictures * (long)uploadTime;

            TimeSpan totalTime = TimeSpan.FromSeconds(time);

            Console.WriteLine(string.Format($"{totalTime.Days:D1}:{totalTime.Hours:D2}:{totalTime.Minutes:D2}:{totalTime.Seconds:D2}"));
        }
    }
}
