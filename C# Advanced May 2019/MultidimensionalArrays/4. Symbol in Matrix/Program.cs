using System;

namespace _4._Symbol_in_Matrix
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char charToCompare = char.Parse(Console.ReadLine());

            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col] == charToCompare)
                    {
                        currentCol = col;
                        currentRow = row;
                    }
                }
                if (currentCol >= 0 || currentRow >= 0)
                {
                    break;
                }
            }

            if (currentRow >= 0)
            {
                Console.WriteLine($"({currentRow}, {currentCol})");
            }
            else
            {
                Console.WriteLine($"{charToCompare} does not occur in the matrix ");
            }
        }
    }
}
