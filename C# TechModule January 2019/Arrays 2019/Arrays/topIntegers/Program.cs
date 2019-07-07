using System;
using System.Linq;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.Write(numbers[numbers.Length - 1]);

        }
    }
}
