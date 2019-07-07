using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tempInput = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tempInput[0] == "swap" && tempInput.Count() == 5)
                {
                    int firstIndex = int.Parse(tempInput[1]);
                    int secondIndex = int.Parse(tempInput[2]);
                    int thirdIndex = int.Parse(tempInput[3]);
                    int fourthIndex = int.Parse(tempInput[4]);

                    if (firstIndex < 0 || firstIndex > matrix.GetLength(0) - 1
                       || secondIndex < 0 || secondIndex > matrix.GetLength(1) - 1
                       || thirdIndex < 0 || thirdIndex > matrix.GetLength(0) - 1
                       || fourthIndex < 0 || fourthIndex > matrix.GetLength(1) - 1)
                    {
                        PrintInvalidResult();
                    }
                    else
                    {
                        string tempElement = matrix[firstIndex, secondIndex];
                        matrix[firstIndex, secondIndex] = matrix[thirdIndex, fourthIndex];
                        matrix[thirdIndex, fourthIndex] = tempElement;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            string[] tempResult = new string[matrix.GetLength(1)];

                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                tempResult[col] = matrix[row,col];
                            }
                            Console.WriteLine(string.Join(" ",tempResult));
                        }
                    }
                }
                else
                {
                    PrintInvalidResult();
                    continue;
                }
            }
        }
        public static void PrintInvalidResult()
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
