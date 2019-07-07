using System;
using System.Linq;

namespace smallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            PrintingSmallestInteger(firstNumber, secondNumber, thirdNumber);  
        }

        private static void PrintingSmallestInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] numbers = new[] { firstNumber, secondNumber, thirdNumber };
            int min = numbers.Min();
            Console.WriteLine(min);
        }
    }
}
