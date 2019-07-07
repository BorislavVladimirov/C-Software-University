using System;

namespace CoolCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string @operator = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (@operator != "end")
            {
                try
                {
                    Console.WriteLine(Calculate(@operator, firstNumber, secondNumber));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                @operator = Console.ReadLine();
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
            }

        }

        private static double Calculate(object oprator, int firstNumber, int secondNumber)
        {
            double result;

            switch (oprator)
            {
                case "add":
                    result = firstNumber + secondNumber;
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                    result = firstNumber / secondNumber;
                    break;
                case "subtract":
                    result = firstNumber - secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("greshen operator brat");
            }

            return result;
        }
    }
}
