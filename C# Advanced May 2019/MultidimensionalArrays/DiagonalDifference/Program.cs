using System;
using System.Linq;

namespace DiagonalDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] firstMatrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] cols = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    firstMatrix[i, j] = cols[j];
                }
            }

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            int currentrow = 0;
            int currentcol = 0;
            int currentReversedCol = firstMatrix.GetLength(1) - 1;

            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                firstDiagonalSum += firstMatrix[currentrow, currentcol];
                secondDiagonalSum += firstMatrix[currentcol, currentReversedCol];

                currentrow++;
                currentcol++;
                currentReversedCol--;
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
