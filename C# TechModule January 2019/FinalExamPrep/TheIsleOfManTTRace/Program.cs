using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TheIsleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^([#$%*&])([A-Za-z]+)\1=(\d+)+!!(.+)";
            bool IsMatchFound = false;

            StringBuilder sb = new StringBuilder();

            while (IsMatchFound == false)
            {
                var regex = new Regex(pattern);

                Match match = regex.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("Nothing found!");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    string name = match.Groups[2].ToString();
                    int num = int.Parse(match.Groups[3].ToString());
                    string geohashCode = match.Groups[4].ToString();

                    if (geohashCode.Length == num)
                    {
                        foreach (char character in geohashCode)
                        {
                            char newCharacter = (char)(character + num);

                            sb.Append(newCharacter);
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {sb}");

                        IsMatchFound = true;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                        input = Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
