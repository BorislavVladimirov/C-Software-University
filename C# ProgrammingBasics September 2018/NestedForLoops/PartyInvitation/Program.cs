using System;
using System.Linq;

namespace PartyInvitation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            bool isvalid = true;
                
            double validNamesCount = 0;
            double invalidNamesCount = 0;
            double totalNamesCount = 0;

            while ((name = Console.ReadLine()) != "Statistic")
            {
                isvalid = true;
                totalNamesCount++;

                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        Console.WriteLine("Invalid name!");
                        invalidNamesCount++;
                        isvalid = false;
                        break;
                    }
                }
                if (isvalid)
                {
                    validNamesCount++;
                    name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();
                    Console.WriteLine(name);
                }
            }   
            double peopleComingPercent = (validNamesCount / totalNamesCount) * 100;
            double peopleNotComingPercent = (invalidNamesCount / totalNamesCount) * 100;

            Console.WriteLine($"Valid names are {peopleComingPercent:f2}% from {totalNamesCount} names.");
            Console.WriteLine($"Invalid names are {peopleNotComingPercent:f2}% from {totalNamesCount} names.");

        }
    }
}
