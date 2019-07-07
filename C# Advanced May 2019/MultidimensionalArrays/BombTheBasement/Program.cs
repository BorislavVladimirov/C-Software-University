using System;
using System.Linq;

namespace BombTheBasement
{
    public class Program
    {
        private static int[,] matrix;

        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] parameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = parameters[0];
            int targetCol = parameters[1];
            int radius = parameters[2];

            matrix = GenerateMatrix(size);

            matrix[targetRow, targetCol] = 1;

            BombRows(radius, targetRow, targetCol);
            BombCol(radius, targetRow, targetCol);
            BombDiagonals(radius, targetRow, targetCol);

            RearangeMatrix();

            PrintMatrix();
        }

        private static void RearangeMatrix()
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row,col] != 0)
                    {
                        MoveUp(row, col);
                        break;
                    }
                }
            }
        }

        private static void MoveUp(int row, int col)
        {
            int couter = 0;

            for (int i = row; i < matrix.GetLength(0); i++)
            {
                if (matrix[i,col] == 0)
                {
                    break;
                }
                matrix[i, col] = 0;
                couter++;
            }

            for (int i = 0; i < couter; i++)
            {
                matrix[i, col] = 1;
            }
        }

        private static void BombDiagonals(int radius, int row, int col)
        {
            for (int i = 1; i <= radius - 1; i++)
            {
                //TopLeft
                if (col - i >= 0 && row - i >= 0)
                {
                    matrix[row - i, col - i] = 1;
                }

                //TopRight
                if (col + i < matrix.GetLength(1) && row - i >= 0)
                {
                    matrix[row - i, col + i] = 1;
                }

                //BottomRight
                if (col + i < matrix.GetLength(1) && row + i < matrix.GetLength(0))
                {
                    matrix[row + i, col + i] = 1;
                }

                //BottomLeft
                if (col - i >= 0 && row + i < matrix.GetLength(0))
                {
                    matrix[row + i, col - i] = 1;
                }
            }
        }

        private static void BombCol(int radius, int row, int col)
        {
            int startIndex = 0;
            int endIndex = 0;

            if (row - radius >= 0 && row + radius < matrix.GetLength(0))
            {
                int range = radius * 2 + 1;
                startIndex = row - radius;

                for (int i = 0; i < range; i++)
                {
                    matrix[startIndex + i, col] = 1;
                }

                return;
            }

            if (row - radius < 0)
            {
                startIndex = 0;
            }

            if (row + radius >= matrix.GetLength(0))
            {
                endIndex = matrix.GetLength(0);
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                matrix[i, col] = 1;
            }
        }

        private static void BombRows(int radius, int row, int col)
        {
            int startIndex = 0;
            int endIndex = 0;

            if (col - radius >= 0 && col + radius < matrix.GetLength(1))
            {
                int range = radius * 2 + 1;
                startIndex = col - radius;

                for (int i = 0; i < range; i++)
                {
                    matrix[row, startIndex + i] = 1;
                }

                return;
            }

            if (col - radius < 0)
            {
                startIndex = 0;
            }

            if (col + radius >= matrix.GetLength(1))
            {
                endIndex = matrix.GetLength(1);
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                matrix[row, i] = 1;
            }
        }

        private static int[,] GenerateMatrix(int[] size)
        {
            matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            return matrix;
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
