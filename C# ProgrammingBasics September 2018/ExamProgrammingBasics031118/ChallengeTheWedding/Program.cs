using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int maleClients = int.Parse(Console.ReadLine());
            int FemaleClients = int.Parse(Console.ReadLine());
            int talbesCount = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= maleClients; i++)
            {
                for (int j = 1; j <= FemaleClients; j++)
                {
                    count++;
                    if (count > talbesCount)
                    {
                        return;
                    }
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
