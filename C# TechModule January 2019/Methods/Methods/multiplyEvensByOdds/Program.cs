using System;
using System.Linq;

namespace multiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                number /= 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                number /= 10;
            }
            return oddSum;
        }
    }
}
