using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNSum = 0;
            int secondNSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstNSum += number;
                }
                else
                {
                    secondNSum += number;
                }
                if (firstNSum == secondNSum)
                {
                    Console.WriteLine($"Yes, sum = {firstNSum}");
                }
                else
                {
                    int diff = firstNSum - secondNSum;
                    Console.WriteLine($"No , diff = {Math.Abs(diff)}");
                }
            }
        }
    }
}
