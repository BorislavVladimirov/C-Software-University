using System;
using System.Linq;

namespace sumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                int currentNumber = intArray[i];

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
