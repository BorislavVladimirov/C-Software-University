using System;

namespace GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int gamesCount = 0;
            int scoredGoals = 0;
            int goalsGot = 0;
            int totalPointCount = 0;
            int goalDiff = 0;
            int goalDifference = 0;

            while (gamesCount < gamesPlayed)
            {
                gamesCount++;

                int goalsScored = int.Parse(Console.ReadLine());                
                int goalsRecieved = int.Parse(Console.ReadLine());

                goalDiff = goalsScored - goalsRecieved;                
                goalDifference += goalDiff;
                scoredGoals += goalsScored;
                goalsGot += goalsRecieved;

                if (goalsScored > goalsRecieved)
                {
                    totalPointCount += 3;
                }
                else if (goalsScored == goalsRecieved)
                {
                    totalPointCount += 1;
                }
            }
            if (scoredGoals >= goalsGot)
            {
                Console.WriteLine($"{name} has finished the group phase with {totalPointCount} points.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }
            else
            {
                Console.WriteLine($"{name} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }
        }
    }
}
