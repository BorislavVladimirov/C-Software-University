using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> games = new Dictionary<string, decimal>();
            Dictionary<string, List<string>> dlcs = new Dictionary<string, List<string>>();


            string input = Console.ReadLine();

            string[] arr = input.Split(", ");

            foreach (var game in arr)
            {
                string name = string.Empty;
                decimal price = 0;
                string dlc = string.Empty;

                string[] tempArr;

                if (game.Contains('-'))
                {
                    tempArr = game.Split("-");
                    name = tempArr[0];
                    price = decimal.Parse(tempArr[1]);

                    games.Add(name, price);

                }
                else
                {
                    tempArr = game.Split(":");
                    name = tempArr[0];
                    dlc = tempArr[1];

                    if (games.ContainsKey(name))
                    {
                        if (!dlcs.ContainsKey(dlc))
                        {
                            dlcs.Add(name, new List<string>());
                            dlcs[name].Add(dlc);
                        }
                        else
                        {
                            dlcs[name].Add(dlc);
                        }
                        games[name] *= 1.2M;
                    }
                }
            }

            foreach (var game in games.OrderBy(x => x.Value))
            {
                if (dlcs.ContainsKey(game.Key))
                {
                Console.WriteLine($"{game.Key} - {string.Join(" ",dlcs[game.Key])} - {(game.Value * 0.5m):f2}");
                }
            }

            foreach (var game in games.OrderByDescending(x => x.Value))
            {
                if (!dlcs.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {(game.Value * 0.8m):f2}");
                }
            }
        }
    }
}
