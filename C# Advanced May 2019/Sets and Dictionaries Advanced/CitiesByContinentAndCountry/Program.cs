using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> result
                = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result.Add(continent, new Dictionary<string, List<string>>());
                    result[continent].Add(country, new List<string>());
                    result[continent][country].Add(city);
                }
                else
                {
                    if (!result[continent].ContainsKey(country))
                    {
                        result[continent].Add(country, new List<string>());
                        result[continent][country].Add(city);
                    }
                    else
                    {
                        result[continent][country].Add(city);
                    }
                }
            }

            foreach (var continent in result)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");

                    List<string> set = new List<string>();

                    foreach (var city in country.Value)
                    {
                        set.Add(city);
                    }
                    Console.Write($"{string.Join(", ",set)} ");
                    Console.WriteLine();
                }
            }
        }
    }
}
