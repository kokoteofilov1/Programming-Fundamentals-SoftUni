using System;

namespace p03_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 >= 60)
            {
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }
                minutes -= 30;
            }
            else
            {
                minutes += 30;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
