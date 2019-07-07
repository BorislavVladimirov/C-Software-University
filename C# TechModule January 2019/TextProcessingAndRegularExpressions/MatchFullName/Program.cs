using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b");

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
