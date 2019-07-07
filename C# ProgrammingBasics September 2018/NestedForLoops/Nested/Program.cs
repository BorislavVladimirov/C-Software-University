using System;

namespace Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"i = {i}");

                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine($"j = {j}");

                }
                Console.WriteLine();
            }
        }
    }
}
