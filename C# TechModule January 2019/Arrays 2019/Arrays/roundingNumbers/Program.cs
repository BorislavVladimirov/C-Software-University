using System;
using System.Linq;

namespace roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                int roundedNumber = (int)Math.Round(currentNumber, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{currentNumber} => {roundedNumber}");
            }
        }
    }
}
