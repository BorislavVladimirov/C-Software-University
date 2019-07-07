using System;
using System.Linq;

namespace evenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    oddSum += currentNumber;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
