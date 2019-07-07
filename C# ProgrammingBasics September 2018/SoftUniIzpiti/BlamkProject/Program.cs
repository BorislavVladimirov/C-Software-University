using System;

namespace BlamkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.WriteLine($"{row}-{col}");
                }
                Console.WriteLine();
            }
        }
    }
}
