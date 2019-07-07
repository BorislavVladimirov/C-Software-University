using System.Linq;
using System.Collections.Generic;
using System;
namespace SnakeMoves
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[] tempArr = snake.ToCharArray();

            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < tempArr.Length; i++)
            {
                queue.Enqueue(tempArr[i]);
            }

            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (queue.Count == 0)
                    {
                        for (int i = 0; i < tempArr.Length; i++)
                        {
                            queue.Enqueue(tempArr[i]);
                        }
                    }
                    matrix[row, col] = queue.Dequeue();
                }
                for (int i = 0; i < tempArr.Length; i++)
                {
                    queue.Enqueue(tempArr[i]);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}