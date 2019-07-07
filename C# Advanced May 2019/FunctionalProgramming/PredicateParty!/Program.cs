using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                string filterCommand = tokens[1];
                string criteria = tokens[2];

                if (command == "Remove")
                {
                    if (filterCommand == "StartsWith")
                    {
                        guests.RemoveAll(x => x.StartsWith(criteria));
                    }
                    else if (filterCommand == "EndsWith")
                    {
                        guests.RemoveAll(x => x.EndsWith(criteria));
                    }
                    else if (filterCommand == "Length")
                    {
                        guests.RemoveAll(x => x.Length == int.Parse(criteria));
                    }
                }
                else if (command == "Double")
                {
                    List<string> guestsToAdd = new List<string>();

                    if (filterCommand == "StartsWith")
                    {
                        guestsToAdd = guests.Where(x => x.StartsWith(criteria)).ToList();
                    }
                    else if (filterCommand == "EndsWith")
                    {
                        guestsToAdd = guests.Where(x => x.EndsWith(criteria)).ToList();
                    }
                    else if (filterCommand == "Length")
                    {
                        guestsToAdd = guests.Where(x => x.Length == int.Parse(criteria)).ToList();
                    }

                    foreach (var name in guestsToAdd)
                    {
                        int index = guests.IndexOf(name);

                        guests.Insert(index + 1, name);
                    }
                }

                input = Console.ReadLine();
            }

            if (guests.Count != 0)
            {
                Console.Write(string.Join(", ", guests));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
