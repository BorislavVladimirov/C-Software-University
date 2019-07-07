using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int longestNumber = 0;
            int longestNumberCount = 0;

            for (int i = 0; i < numbers.Length -1 ; i++)
            {
                int currentNumber = numbers[i];
                int currentCount = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        currentCount++;

                        if (longestNumberCount < currentCount)
                        {
                            longestNumberCount = currentCount;
                            longestNumber = currentNumber;
                            i = j;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < longestNumberCount; i++)
            {
                Console.Write(longestNumber + " ");
            }
        }
    }
}
