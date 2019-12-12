using System;
using System.Linq;

namespace p12_MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                if (CheckMasterNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckMasterNumber(int n)
        {
            string numToString = n.ToString();
            char[] numArr = numToString.ToCharArray();
            Array.Reverse(numArr);
            string reversedNumToString = new string(numArr);

            bool isPalindrome = numToString == reversedNumToString;

            int sumOfDigits = 0;
            bool hasEvenDigit = false;

            while (n > 0)
            {
                int currentDigit = n % 10;

                sumOfDigits += currentDigit;

                if (currentDigit % 2 == 0)
                {
                    hasEvenDigit = true;
                }

                n /= 10;
            }

            bool sumIsDivisibleBySeven = sumOfDigits % 7 == 0;

            if (isPalindrome && sumIsDivisibleBySeven && hasEvenDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
