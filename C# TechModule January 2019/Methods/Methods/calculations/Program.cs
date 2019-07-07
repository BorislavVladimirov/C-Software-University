using System;

namespace calculations
{
    class Program
    {
        private static double result = 0;
        
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();//add,multiply,substract,divide
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    AddingNumbers(operation, firstNumber, secondNumber);
                    break;
                case "multiply":
                    MultiplingNumbers(operation, firstNumber, secondNumber);
                    break;
                case "subtract":
                    SubstractingNumbers(operation, firstNumber, secondNumber);
                    break;
                case "divide":
                    DividingNumbers(operation, firstNumber, secondNumber);
                    break;
            }
        }

        private static void AddingNumbers(string operation, int firstNumber, int secondNumber)
        {
            result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        private static void DividingNumbers(string operation, int firstNumber, int secondNumber)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }

        private static void SubstractingNumbers(string operation, int firstNumber, int secondNumber)
        {
            result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        private static void MultiplingNumbers(string operation, int firstNumber, int secondNumber)
        {
            result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
    }
}
