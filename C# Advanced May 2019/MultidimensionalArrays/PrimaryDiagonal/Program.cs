using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];


            for (int i = 0; i < size; i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            int sum = 0;
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[currentRow, currentCol];

                currentRow++;
                currentCol++;
            }
            Console.WriteLine(sum);
        }
    }
}
