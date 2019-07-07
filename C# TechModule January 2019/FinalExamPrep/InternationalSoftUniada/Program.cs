using System;
using System.Collections.Generic;
using System.Linq;

namespace InternationalSoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, int>>();

            while (input != "END")
            {
                string[] tempArr = input.Split(" -> ");

                string countryName = tempArr[0];
                string contestantName = tempArr[1];
                int contestantPoints = int.Parse(tempArr[2]);

                if (!result.ContainsKey(countryName))
                {
                    result.Add(countryName, new Dictionary<string, int>());
                    result[countryName].Add(contestantName, contestantPoints);
                }
                else
                {
                    if (!result[countryName].ContainsKey(contestantName))
                    {
                        result[countryName].Add(contestantName, contestantPoints);
                    }
                    else
                    {
                        result[countryName][contestantName] += contestantPoints;
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var country in result.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");

                foreach (var contestant in country.Value)
                {
                    Console.WriteLine($" -- {contestant.Key} -> {contestant.Value}");
                }
            }
        }
    }
}
