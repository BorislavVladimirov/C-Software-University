using System;

namespace NestedFoorLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"I = {i}");

                for (int j = 0; i < b; i++)
                {
                    Console.WriteLine($"j = {j}");

                    for (int k = 0; k < c; k++)
                    {
                        Console.WriteLine($"k = {k}");
                    }
                }
            }
        }
    }
}
