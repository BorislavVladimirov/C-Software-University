using System;

namespace Kosta
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= 8; i++)
            {
                for (int y = 9; y >= b; y--)
                {
                    for (int z = c; z <= 8; z++)
                    {
                        for (int x = 9; x >= d; x--)
                        {
                            if (i % 2 == 0 && y % 2 != 0 && z % 2 == 0 && x % 2 != 0)
                            {

                                if (i * 10 + y == z * 10 + x)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{y} - {z}{x}");
                                    count++;
                                }
                                if (count == 6)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
