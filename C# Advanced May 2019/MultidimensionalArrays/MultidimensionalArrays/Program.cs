using System;

namespace MultidimensionalArrays
{
    class Program
    {
        public static void Main()
        {
            //    int[,] intMatrix = new int[3, 4];
            //    float[,] floatMatrix = new float[8, 2];
            //    string[,,] stringCube = new string[5, 5, 5];

            // the sum ot , + 1 represents the count of indexes

            //Initializing with values multidimensional array:
            //int[,] matrix = {
            //    {1, 2, 3, 4}, // row 0 values
            //    {5, 6, 7, 8} // row 1 values
            //    };

            //Getting element value:
            //int[,] array = {{1, 2}, {3, 4}}
            //int element11 = array[1, 1]; // element11 = 4

            //Setting element value:
            ////  int[,] array = new int[3, 4];
            //for (int row = 0; row < array.GetLength(0); row++)
            //    for (int col = 0; col < array.GetLength(1); col++)
            //        array[row, col] = row + col;

            // Printing Matrix – Example
            // int[,] matrix =
            //{ { 5, 2, 3, 1 },
            //{ 1, 9, 2, 4 },
            //{ 9, 8, 6, 11 } };
            //   for (int row = 0; row < matrix.GetLength(0); row++)
            //   {
            //       for (int col = 0; col < matrix.GetLength(1); col++)
            //       {
            //           Console.Write("{0} ", matrix[row, col]);
            //       }
            //       Console.WriteLine();
            //   }

            ////Printing Matrix – Example (2)
            //int[,] matrix = {
            //{ 5, 2, 3, 1 },
            //{ 1, 9, 2, 4 },
            //{ 9, 8, 6, 9 }
            //};
            //foreach (int element in matrix)
            //{
            //    Console.WriteLine(element);
            //}




            ////JAGGED ARRAYS 
            ///
            //A jagged array is an array of arrays
            //Each of the arrays has different length
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[3];
            //jagged[1] = new int[2];

            //Filling a Jagged Array
            //int[][] jagged = new int[5][];
            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    string[] inputNumbers = Console.ReadLine().Split(' ');
            //    jagged[row] = new int[inputNumbers.Length];
            //    for (int col = 0; col < jagged[row].Lenght; col++)
            //    {
            //        jagged[row][col] = int.Parse(inputNumbers[col]);
            //    }
            //}

            //Printing а Jagged Array - Example:
            //with for loop
            ////int[][] matrix = ReadMatrix();
            //for (int row = 0; row < matrix.Length; row++)
            //    for (int col = 0; col < matrix[row].Length; col++)
            //        Console.Write("{0} ", matrix[row][col]);
            //Console.WriteLine();
            //
            //with foreach
            //int[][] matrix = ReadMatrix();
            //foreach (int[] row in matrix)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}
        }
    }
}
