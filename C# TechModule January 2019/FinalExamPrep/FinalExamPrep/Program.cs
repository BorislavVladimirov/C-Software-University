using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(?<=^|&)([a-zA-Z0-9]+)(?=&|$)";

            List<string> result = new List<string>();
            List<string> final = new List<string>();

            var matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                result.Add(match.ToString().ToUpper());
            }

            for (int i = 0; i < result.Count; i++)
            {
                string currentResult = result[i]; // group of 16 or 25 chars

                if (currentResult.Length == 16)
                {
                    for (int j = 0; j < currentResult.Length; j++)
                    {
                        char currentChar = currentResult[j];

                        if (char.IsDigit(currentChar))
                        {
                            int numberToReplace = int.Parse(currentChar.ToString());
                            string newNumber = (9 - numberToReplace).ToString();

                            currentResult = currentResult.Remove(j, 1);
                            currentResult = currentResult.Insert(j, newNumber);
                        }
                    }
                    currentResult = currentResult.Insert(4, "-");
                    currentResult = currentResult.Insert(9, "-");
                    currentResult = currentResult.Insert(14, "-");

                    final.Add(currentResult);
                }
                else if (currentResult.Length == 25)
                {
                    for (int j = 0; j < currentResult.Length; j++)
                    {
                        char currentChar = currentResult[j];

                        if (char.IsDigit(currentChar))
                        {
                            int numberToReplace = int.Parse(currentChar.ToString());
                            string newNumber = (9 - numberToReplace).ToString();

                            currentResult = currentResult.Remove(j, 1);
                            currentResult = currentResult.Insert(j, newNumber);
                        }
                    }
                    currentResult = currentResult.Insert(5, "-");
                    currentResult = currentResult.Insert(11, "-");
                    currentResult = currentResult.Insert(17, "-");
                    currentResult = currentResult.Insert(23, "-");

                    final.Add(currentResult);
                }
            }

            Console.WriteLine(string.Join(", ", final));
        }
    }
}
