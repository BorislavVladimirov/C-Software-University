using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().
                Split(" ").
                Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().
                    Split(" ").ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] array = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (array[0] == "swap" && array.Length == 5)
                {
                    int row1 = int.Parse(array[1]);
                    int col1 = int.Parse(array[2]);
                    int row2 = int.Parse(array[3]);
                    int col2 = int.Parse(array[4]);

                    if (row1 < matrix.GetLength(0) && row2 < matrix.GetLength(0) &&
                        col1 < matrix.GetLength(1) && col2 < matrix.GetLength(1))
                    {
                        string num1 = matrix[row1, col1];
                        string num2 = matrix[row2, col2];

                        matrix[row1, col1] = num2;
                        matrix[row2, col2] = num1;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}