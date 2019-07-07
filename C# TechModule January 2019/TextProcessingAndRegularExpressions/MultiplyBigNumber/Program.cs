using System;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNumber = Console.ReadLine().Split().ToArray();

            int secondNumber = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(firstNumber[i]);

                int tempResult = currentNumber * secondNumber;

                int resultToAdd = 0;

                if (tempResult > 10)
                {
                    result += tempResult % 10;
                    resultToAdd = tempResult / 10;
                }
                else
                {
                    result += tempResult;
                }

            }
            Console.WriteLine(result);
        }
    }
}
