using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<List<string>, int>> bands = new Dictionary<string, Dictionary<List<string>, int>>();
            
            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] tempArr = input.Split("; ");
                string bandName = tempArr[1];

                switch (tempArr[0])
                {
                    case "Add":
                        string[] tempMembers = tempArr[2].Split(", ");
                        
                        if (!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new Dictionary<List<string>, int>());
                            bands[bandName].Add(new List<string>(), 0);
                        }

                        foreach (var member in tempMembers)
                        {
                            foreach (var key in bands[bandName].Keys)
                            {
                                if (!key.Contains(member))
                                {
                                    key.Add(member);
                                }
                            }
                        }
                        break;
                    case "Play":
                        int time = int.Parse(tempArr[2]);

                        if (!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new Dictionary<List<string>, int>());
                            bands[bandName].Add(new List<string>(), time);
                        }
                        else
                        {
                            bands[bandName][bands[bandName].Keys.First()] += time;
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            string finalInput = Console.ReadLine();

            Console.WriteLine($"Total time: {bands.Values.Sum(x => x.Values.Sum(y => y))}");

            foreach (var band in bands.OrderByDescending(x => x.Value.Values.First()).ThenBy(x => x.Key))
            {
                foreach (var time in band.Value)
                {
                    Console.WriteLine($"{band.Key} -> {time.Value}");
                }
            }

            Console.WriteLine($"{finalInput}");

            foreach (var member in bands[finalInput].Keys.First())
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
