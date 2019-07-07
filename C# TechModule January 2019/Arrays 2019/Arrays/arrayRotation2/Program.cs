using System;
using System.Linq;

namespace arrayRotation2
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
            int firstNumber = 0;
            int number = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                     firstNumber = numbers[0];
                    number = firstNumber;
                    numbers[j] = numbers[j + 1];

                    
                }
                numbers[numbers.Length - 1] = number;


            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
