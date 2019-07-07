using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var countries = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();

            while (input != "end")
            {
                string country = string.Empty;
                string city = string.Empty;
                string district = string.Empty;
                int peopleCount = 0;

                string[] tempArr = input.Split();

                country = tempArr[0];
                city = tempArr[1];


                switch (tempArr.Length)
                {
                    case 2:
                        if (!countries.ContainsKey(country))
                        {
                            countries.Add(country, new Dictionary<string, Dictionary<string, int>>());
                            countries[country].Add(city, new Dictionary<string, int>());
                        }
                        else
                        {
                            if (!countries[country].ContainsKey(city))
                            {
                                countries[country].Add(city, new Dictionary<string, int>());
                            }
                        }
                        break;
                    case 3:

                        district = tempArr[2];

                        if (!countries.ContainsKey(country))
                        {
                            countries.Add(country, new Dictionary<string, Dictionary<string, int>>());
                            countries[country].Add(city, new Dictionary<string, int>());
                            countries[country][city].Add(district, 0);
                        }
                        else
                        {
                            if (!countries[country].ContainsKey(city))
                            {
                                countries[country].Add(city, new Dictionary<string, int>());
                                countries[country][city].Add(district, 0);
                            }
                            else
                            {
                                if (!countries[country][city].ContainsKey(district))
                                {
                                    countries[country][city].Add(district, 0);
                                }
                            }
                        }
                        break;
                    case 4:

                        district = tempArr[2];
                        peopleCount = int.Parse(tempArr[3]);

                        if (!countries.ContainsKey(country))
                        {
                            countries.Add(country, new Dictionary<string, Dictionary<string, int>>());
                            countries[country].Add(city, new Dictionary<string, int>());
                            countries[country][city].Add(district, peopleCount);
                        }
                        else
                        {
                            if (!countries[country].ContainsKey(city))
                            {
                                countries[country].Add(city, new Dictionary<string, int>());
                                countries[country][city].Add(district, peopleCount);
                            }
                            else
                            {
                                if (!countries[country][city].ContainsKey(district))
                                {
                                    countries[country][city].Add(district, peopleCount);
                                }
                                else
                                {
                                    countries[country][city][district] += peopleCount;
                                }
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(x => x.Value
                        .Values.Sum(y => y.Values.Sum())).ThenBy(x => x.Key))
            {
                int count = country.Value.Values.Sum(y => y.Values.Sum());

                Console.WriteLine($"{country.Key}: {count}");

                foreach (var city in country.Value.OrderByDescending(c => c.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {city.Key}: {city.Value.Count} districts, {city.Value.Values.Sum()} people");

                    foreach (var district in city.Value.OrderByDescending(d => d.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"-- {district.Key} : {district.Value}");
                    }
                }
            }
        }

    }
}
