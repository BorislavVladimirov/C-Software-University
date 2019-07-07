using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsAndPoint = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] inputLine = input.Split('-');

                string name = inputLine[0];

                if (inputLine[1] == "banned")
                {
                    studentsAndPoint.Remove(name);
                }
                else
                {
                    string language = inputLine[1];
                    int points = int.Parse(inputLine[2]);

                    if (!studentsAndPoint.ContainsKey(name))
                    {
                        studentsAndPoint[name] = points;
                    }
                    else if (points > studentsAndPoint[name])
                    {
                        studentsAndPoint[name] = points;
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions[language] = 0;
                    }
                    submissions[language]++;
                }


            }
            Console.WriteLine("Results:");

            foreach (var kvp in studentsAndPoint.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");

            foreach (var kvp in submissions.OrderByDescending(x=> x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
