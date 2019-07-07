using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dim[0], dim[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = token[j];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
