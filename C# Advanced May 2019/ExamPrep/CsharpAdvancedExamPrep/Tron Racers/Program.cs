using System;

namespace Tron_Racers
{
    public class StartUp
    {
        private static int fRow;
        private static int fCol;

        private static int sRow;
        private static int sCol;

        private static char[,] matrix;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            matrix = GenerateMatrix(n);

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string firstCommand = input[0];
                string secondCommand = input[1];

                if (!Move(firstCommand, 'f'))
                {
                    Print();
                    return;
                }

                if (!Move(secondCommand, 's'))
                {
                    Print();
                    return;
                }
            }
        }

        private static bool Move(string directin, char role)
        {
            switch (directin)
            {
                case "up":
                    if (role == 'f')
                    {
                        return UpDown(fRow - 1, role);
                    }
                    else
                    {
                        return UpDown(sRow - 1, role);
                    }
                case "down":
                    if (role == 'f')
                    {
                        return UpDown(fRow + 1, role);
                    }
                    else
                    {
                        return UpDown(sRow + 1, role);
                    }
                case "left":
                    if (role == 'f')
                    {
                        return LeftRight(fCol - 1, role);
                    }
                    else
                    {
                        return LeftRight(sCol - 1, role);
                    }
                case "right":
                    if (role == 'f')
                    {
                        return LeftRight(fCol + 1, role);
                    }
                    else
                    {
                        return LeftRight(sCol + 1, role);
                    }
                default:
                    return true;
            }
        }

        private static bool LeftRight(int index, char role)
        {
            if (index < 0)
            {
                index = matrix.GetLength(1) - 1;
            }

            if (index >= matrix.GetLength(1))
            {
                index = 0;
            }

            if (role == 'f')
            {
                if (matrix[fRow, index] == 's')
                {
                    matrix[fRow, index] = 'x';
                    return false;
                }

                fCol = index;
                matrix[fRow, fCol] = 'f';
            }
            else if (role == 's')
            {
                if (matrix[sRow, index] == 'f')
                {
                    matrix[sRow, index] = 'x';
                    return false;
                }

                sCol = index;
                matrix[sRow, sCol] = 's';
            }

            return true;
        }

        private static bool UpDown(int index, char role)
        {
            if (index < 0)
            {
                index = matrix.GetLength(0) - 1;
            }

            if (index >= matrix.GetLength(0))
            {
                index = 0;
            }

            if (role == 'f')
            {
                if (matrix[index, fCol] == 's')
                {
                    matrix[index, fCol] = 'x';
                    return false;
                }

                fRow = index;
                matrix[fRow, fCol] = 'f';
            }
            else if (role == 's')
            {
                if (matrix[index, sCol] == 'f')
                {
                    matrix[index, sCol] = 'x';
                    return false;
                }

                sRow = index;
                matrix[sRow, sCol] = 's';
            }

            return true;
        }

        private static char[,] GenerateMatrix(int n)
        {
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    if (cols[col] == 'f')
                    {
                        fRow = row;
                        fCol = col;
                    }

                    if (cols[col] == 's')
                    {
                        sRow = row;
                        sCol = col;
                    }

                    matrix[row, col] = cols[col];
                }
            }

            return matrix;
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
