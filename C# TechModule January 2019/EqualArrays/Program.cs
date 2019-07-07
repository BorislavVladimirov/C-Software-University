using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                        
            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                int FirstCurrentNumber = firstArr[i];
                int secondCurrentNumber = secondArr[i];

                if (FirstCurrentNumber == secondCurrentNumber)
                {
                    sum += FirstCurrentNumber;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }
            Console.WriteLine($"Arrays are identical. Sum: {sum} ");

        }
    }
}
