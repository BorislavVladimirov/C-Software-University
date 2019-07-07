using System;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            double result = FactorialDivision(firstNumber, secondNumber);
            Console.WriteLine($"{result:f2}");
            
        }
        private static double FactorialDivision(long firstNumber, long secondNumber)
        {
            long firstResult = 1;
            long secondResult = 1;

            for (int i = 1; i <= firstNumber; i++)
            {
                firstResult *= i;
            }
            for (int i = 1; i <= secondNumber; i++)
            {
                secondResult *= i;
            }
            return 1.0*firstResult / secondResult;
        }
    }
}
