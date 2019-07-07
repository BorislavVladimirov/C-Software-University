using System;

namespace test
{
    class Program
    {
        private static int[,] matrix;

        private static int sum;

        static void Main(string[] args)
        {
            GenerateMatrix();

            Console.WriteLine(PrintSum(0,0));
        }

        private static int PrintSum(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return 0;
            }

            sum += GetSum(row, col);

            PrintSum(row + 1, 0);

            return sum;
        }

        private static int GetSum(int row, int col)
        {
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return 0;
            }

            return matrix[row, col] + GetSum(row, col + 1);
        }

        private static void GenerateMatrix()
        {
            matrix = new int[5, 5];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 1;
                }
            }
        }
    }
}
