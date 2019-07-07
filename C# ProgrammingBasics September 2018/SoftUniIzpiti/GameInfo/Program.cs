using System;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());

            int gamesWithAddTime = 0;
            int gamesWithPenalties = 0;
            double avgGameDuration = 0;
            int totalTime = 0;

            for (int i = 0; i < gamesCount; i++)
            {
                int gameDuration = int.Parse(Console.ReadLine());

                avgGameDuration += gameDuration;
                totalTime += gameDuration;

                if (gameDuration > 90 && gameDuration <= 120)
                {
                    gamesWithAddTime++;
                }
                else if (gameDuration > 120)
                {
                    gamesWithPenalties++;
                }


            }
            avgGameDuration = avgGameDuration / gamesCount;

            Console.WriteLine($"{name} has played {totalTime} minutes. Average minutes per game: {avgGameDuration:f2}");
            Console.WriteLine($"Games with penalties: {gamesWithPenalties}");
            Console.WriteLine($"Games with additional time: {gamesWithAddTime}");
        }
    }
}
