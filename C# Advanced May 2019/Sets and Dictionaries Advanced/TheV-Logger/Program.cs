using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers
                = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string followers = "followers";
            string following = "following";

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] inputArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentVlogger = inputArr[0];
                string typeOfCommand = inputArr[1];

                if (typeOfCommand == "joined")
                {
                    if (!vloggers.ContainsKey(currentVlogger))
                    {
                        vloggers.Add(currentVlogger, new Dictionary<string, SortedSet<string>>());
                    }

                    vloggers[currentVlogger].Add(following, new SortedSet<string>());
                    vloggers[currentVlogger].Add(followers, new SortedSet<string>());
                }
                else if (typeOfCommand == "followed")
                {
                    string followedVlogger = inputArr[2];

                    if (followedVlogger == currentVlogger)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    vloggers[followedVlogger][followers].Add(currentVlogger);
                    vloggers[currentVlogger][following].Add(followedVlogger);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count()} vloggers in its logs.");

            int count = 0;

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value[followers].Count()).ThenBy(x => x.Value[following].Count))
            {
                if (count == 0)
                {
                    Console.WriteLine($"{++count}. {vlogger.Key} : {vlogger.Value[followers].Count} followers, {vlogger.Value[following].Count} following");
                    foreach (var v in vlogger.Value[followers])
                    {
                        Console.WriteLine($"*  {v}");
                    }

                    continue;
                }

                Console.WriteLine($"{++count}. {vlogger.Key} : {vlogger.Value[followers].Count} followers, {vlogger.Value[following].Count} following");
            }
        }

    }
}
