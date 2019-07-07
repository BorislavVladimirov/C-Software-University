using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> users = new Dictionary<string, int>(); // users and points 
            Dictionary<string, int> submissions = new Dictionary<string, int>(); // language and submissionsCount

            while (input != "exam finished")
            {
                string[] tempArr = input.Split("-");

                string username = tempArr[0];

                if (tempArr.Length == 2)
                {
                    users.Remove(username);
                }
                else if (tempArr.Length == 3)
                {
                    string language = tempArr[1];
                    int points = int.Parse(tempArr[2]);

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, points);
                    }
                    else if (users.ContainsKey(username) && (submissions.ContainsKey(language)))
                    {
                        if (users[username] < points)
                        {
                            users[username] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var user in users.OrderByDescending(u => u.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissions.OrderByDescending(l => l.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
