using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
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
