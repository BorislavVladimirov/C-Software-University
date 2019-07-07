using System;

namespace addAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SummingFirstTwoNumbers(firstNumber,secondNumber);
            int result = SummingFirstTwoNumbers(firstNumber, secondNumber);
            SubtractingThitdNumberFromSum(thirdNumber, result);
            int finalResult = SubtractingThitdNumberFromSum(thirdNumber, result);

            Console.WriteLine(finalResult);
        }
        private static int SubtractingThitdNumberFromSum(int thirdNumber, int result)
        {
            return result - thirdNumber;
        }

        private static int SummingFirstTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
