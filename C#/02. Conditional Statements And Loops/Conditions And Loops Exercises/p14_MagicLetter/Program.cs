using System;

namespace p14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();

            string combination = "";
            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        combination = $"{i}{j}{k}";
                        if (!combination.Contains(skip))
                        {
                            Console.Write(combination + " ");
                        }
                    }
                }
            }
        }
    }
}
