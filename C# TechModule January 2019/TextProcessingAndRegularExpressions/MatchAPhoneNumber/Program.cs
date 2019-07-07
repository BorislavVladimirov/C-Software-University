using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchAPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, @"[\+][3][5][9]([ -])[2]\1\d{3}\1\d{4}\b");

            string[] result = new string[matches.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matches[i].ToString();
            }
                Console.Write(string.Join(", ", result));
        }
    }
}
