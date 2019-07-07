using System;

namespace printingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
            PrintReversedTriangle(number);
        }
        private static void PrintRowWithNumbers(int row)
        {
            for (int number = 1; number <= row; number++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void PrintReversedTriangle(int MaxNumber)
        {
            for (int row = MaxNumber -1 ; row >= 1; row--)
            {
                PrintRowWithNumbers(row);
            }
        }

        private static void PrintTriangle(int MaxNumber)
        {
            for (int row = 1; row <= MaxNumber; row++)
            {
                PrintRowWithNumbers(row);
            }
        }
        
    }
}
