using System;

namespace p09_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();

            foreach (char character in array)
            {
                Console.WriteLine($"{character} -> {Convert.ToInt32(character) - 97}");
            }
        }
    }
}
