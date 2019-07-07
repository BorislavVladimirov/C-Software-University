using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main()
        {
            int[] dimestions = CommandSplit();

            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];

            GenerateMAtrix(x, y, matrix);

            string command = Console.ReadLine();

            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] ivoS = command
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int[] evil = CommandSplit();

                int evilRow = evil[0];
                int evilCol = evil[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }

                    evilRow--;
                    evilCol--;
                }

                int rowIvo = ivoS[0];
                int colIvo = ivoS[1];

                while (rowIvo >= 0 && colIvo < matrix.GetLength(1))
                {
                    if (rowIvo >= 0 && rowIvo < matrix.GetLength(0) && colIvo >= 0 && colIvo < matrix.GetLength(1))
                    {
                        sum += matrix[rowIvo, colIvo];
                    }

                    colIvo++;
                    rowIvo--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static int[] CommandSplit()
        {
            return Console.ReadLine()
                     .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
        }

        private static void GenerateMAtrix(int x, int y, int[,] matrix)
        {
            int value = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
