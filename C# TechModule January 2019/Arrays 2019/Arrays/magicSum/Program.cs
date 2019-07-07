using System;
using System.Linq;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNumber = numbers[j];

                    if (firstNumber + secondNumber == n)
                    {
                        Console.Write(firstNumber + " " + secondNumber);
                        Console.WriteLine();
                    }
                }
                

            }
            
        }
    }
}
