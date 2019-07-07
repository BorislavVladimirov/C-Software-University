using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathern = Console.ReadLine();
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matches = Regex.Matches(pathern, regex);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
