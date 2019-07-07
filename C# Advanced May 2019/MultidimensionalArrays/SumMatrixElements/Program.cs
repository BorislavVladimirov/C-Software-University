using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMatrixElements
{
    class StartUp
    {
        public static void Main()
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dim[0], dim[1]];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] token = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = token[j];
                    sum += token[j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
