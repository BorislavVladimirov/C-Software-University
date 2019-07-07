using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();

            ContestsFill(input, contests);

            input = Console.ReadLine();

            SubmissionsFill(input, submissions, contests);
            PrintResult(submissions);            

        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> submissions)
        {
            string bestCandidate = string.Empty;
            int tempPoints = 0;

            foreach (var contestant in submissions)
            {
                if (contestant.Value.Values.Sum() > tempPoints)
                {
                    tempPoints = contestant.Value.Values.Sum();
                    bestCandidate = contestant.Key.ToString();
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {tempPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var contestant in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var contest in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        public static void SubmissionsFill(string input, Dictionary<string, Dictionary<string, int>> submissions, Dictionary<string, string> contests)
        {
            while (input != "end of submissions")
            {
                string[] tempInput = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string currentcontest = tempInput[0];
                string password = tempInput[1];
                string username = tempInput[2];
                int points = int.Parse(tempInput[3]);

                if (contests.ContainsKey(currentcontest))
                {
                    if (contests[currentcontest] == password)
                    {
                        if (!submissions.ContainsKey(username))
                        {
                            submissions.Add(username, new Dictionary<string, int>());
                            submissions[username][currentcontest] = points;
                        }
                        else
                        {
                            if (submissions[username].ContainsKey(currentcontest))
                            {
                                if (submissions[username][currentcontest] < points)
                                {
                                    submissions[username][currentcontest] = points;
                                }
                            }
                            else
                            {
                                submissions[username].Add(currentcontest, points);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        public static void ContestsFill(string input, Dictionary<string, string> contests)
        {
            while (input != "end of contests")
            {
                string[] tempArr = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = tempArr[0];
                string password = tempArr[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                input = Console.ReadLine();
            }
        }
    }
}
