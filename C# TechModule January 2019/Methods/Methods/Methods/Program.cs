using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintSighn(int.Parse(Console.ReadLine()));
        }

        static void PrintSighn(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
