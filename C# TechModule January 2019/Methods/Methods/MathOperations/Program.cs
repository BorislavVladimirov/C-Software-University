using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            
            switch (@operator)
            {
                case "/":
                    DividingNumbers(firstNumber, @operator, secondNumber);
                    break;
                case "*":
                    MultiplingNumbers(firstNumber, @operator, secondNumber);
                    break;
                case "+":
                    AddingNumber(firstNumber, @operator, secondNumber);
                    break;
                case "-":
                    SubtractingNumbers(firstNumber, @operator, secondNumber);
                    break;
            }
        }

        private static void SubtractingNumbers(int firstNumber, string @operator, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        private static void
            AddingNumber(int firstNumber, string @operator, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        private static void MultiplingNumbers(int firstNumber, string @operator, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        static void DividingNumbers(int firstNumber, string @operator, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}
