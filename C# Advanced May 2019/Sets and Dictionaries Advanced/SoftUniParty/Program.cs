using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> guests = new List<string>();

            while (input != "PARTY")
            {
                if (input == "END")
                {
                    PrintResult(guests);
                    return;
                }
                if (char.IsDigit(input[0]))
                {
                    guests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }

            PrintResult(guests);
        }

        private static void PrintResult(List<string> absentGuests)
        {
            Console.WriteLine($"{absentGuests.Count}");

            foreach (var person in absentGuests.Where(x => char.IsDigit(x[0])))
            {
                Console.WriteLine(person);
            }
            foreach (var person in absentGuests.Where(x => char.IsLetter(x[0])))
            {
                Console.WriteLine(person);
            }
        }
    }
}
