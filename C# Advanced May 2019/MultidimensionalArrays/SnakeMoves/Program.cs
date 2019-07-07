using System;
using System.Collections.Generic;
using System.Linq;

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
            
            Queue<char> queue = new Queue<char>();

            snake.ToList().ForEach(x => queue.Enqueue(x));
                
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char temp = queue.Dequeue();

                    matrix[row, col] = temp;

                    queue.Enqueue(temp);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
