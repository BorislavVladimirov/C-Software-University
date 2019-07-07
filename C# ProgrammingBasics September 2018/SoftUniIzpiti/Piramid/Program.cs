using System;

namespace Piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    count++;
                    Console.Write($"{count}");
                    Console.WriteLine();


                    if (count == n )
                    {
                        return;
                    }
                }
            }
        }
    }
}
