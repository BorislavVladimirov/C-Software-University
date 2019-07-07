using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicesessions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> practiceSession = new Dictionary<string, List<string>>(); 

            while (input != "END")
            {
                string[] tempArr = input.Split("->");

                string command = tempArr[0];
                string road = tempArr[1];

                switch (command)
                {
                    case "Add":
                        string racer = tempArr[2];

                        if (!practiceSession.ContainsKey(road))
                        {
                            practiceSession.Add(road, new List<string>());
                            practiceSession[road].Add(racer);
                        }
                        else
                        {
                            practiceSession[road].Add(racer);
                        }
                        break;
                    case "Move":
                        string tempRacer = tempArr[2];
                        string nextRoad = tempArr[3];

                        if (practiceSession[road].Contains(tempRacer))
                        {
                            practiceSession[nextRoad].Add(tempRacer);
                            practiceSession[road].Remove(tempRacer);
                        }
                        break;
                    case "Close":

                        if (practiceSession.ContainsKey(road))
                        {
                            practiceSession.Remove(road);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Practice sessions:");

            foreach (var road in practiceSession.OrderByDescending(r => r.Value.Count).ThenBy(r => r.Key))
            {
                Console.WriteLine(road.Key);

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
