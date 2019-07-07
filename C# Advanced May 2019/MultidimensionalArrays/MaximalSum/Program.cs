using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = size[0];
            int m = size[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }
            int maxSum = int.MinValue;

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            int tempCol = currentCol;

            for (int i = 0; i < 3; i++)
            {
                int[] result = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    result[j] = matrix[currentRow, currentCol];
                    currentCol++;
                }
                Console.WriteLine(string.Join(" ",result));
                currentRow++;
                currentCol = tempCol;
            }
        }
    }
}
