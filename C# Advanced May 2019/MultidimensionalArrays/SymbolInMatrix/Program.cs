using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = cols[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            int currentRow = 0;
            int currentCol = 0;
            bool isMachFound = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        currentRow = i;
                        currentCol = j;
                        isMachFound = true;
                        break;
                    }
                }
                if (isMachFound)
                {
                    break;
                }
            }
            if (isMachFound)
            {
                Console.WriteLine($"({currentRow}, {currentCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
