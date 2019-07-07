using System;

namespace multidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] intMatrix = new int[3, 4];
            //float[,,] floaMatric = new float[8, 4, 3];


            string[,] cities =
               {
                {"Sofia", "Plovdiv"},
                {"Varna", "Bourgas"},
                {"Veliko Turnovo", "Yambol" },
                };
            //Console.WriteLine(arr[1, 1]);

            for (int row = 0; row < cities.GetLength(0); row++)
            {
                for (int col = 0; col < cities.GetLength(1); col++)
                {
                    Console.WriteLine(cities[row,col]);
                }
            }
            //foreach (var city in cities)
            {
                //Console.WriteLine(city);
            }
        }
        
    }
}
