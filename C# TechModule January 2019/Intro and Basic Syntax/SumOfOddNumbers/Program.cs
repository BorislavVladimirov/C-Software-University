using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;
            for (int i = 1; i <= oddNumbersCount; i++)
            {                     
                
                Console.WriteLine($"{number}");                
                sum += number;
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
