using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int changesDone = 0;

            for (int i = K; i <= 8; i++)
            {
                for (int j = 9; j >= L; j--)
                {
                    for (int t = M; t <= 8; t++)
                    {
                        for (int e = 9; e >= N; e--)
                        {
                            if (i % 2 == 0 && t % 2 == 0 && j % 2 == 1 && e % 2 == 1)
                            {

                                changesDone++;

                                if (i == t && j == e)
                                {
                                    changesDone--;
                                    Console.WriteLine($"Cannot change the same player.");
                                    continue;
                                }
                                Console.WriteLine($"{i}{j} - {t}{e}");

                                if (changesDone == 6)
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
