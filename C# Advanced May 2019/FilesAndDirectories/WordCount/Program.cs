using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            string[] words = File.ReadAllLines(Path.Combine("Files", "words.txt"));
            string[] text = File.ReadAllLines(Path.Combine("Files", "text.txt"));

            for (int i = 0; i < words.Length; i++)
            {
                result.Add(words[i], 0);
            }

            for (int i = 0; i < text.Length; i++)
            {
                foreach (var word in text[i].Split())
                {
                    if (word.Trim('.', '-', '?', ',').ToLower() == words[0])
                    {
                        result[words[0]]++;
                    }
                    else if (word.Trim('.', '-', '?', ',').ToLower() == words[2])
                    {
                        result[words[2]]++;
                    }
                    else if (word.Trim('.', '-', '?', ',').ToLower() == words[1])
                    {
                        result[words[1]]++;
                    }
                }
            }

            string pathActual = "..//..//..//Files//actualResult.txt";
            string pathExpected = "..//..//..//Files//expectedResult.txt";

            var sb = new StringBuilder();

            foreach (var kvp in result)
            {
                sb.AppendLine($"{kvp.Key} - {kvp.Value}");
            }

            File.WriteAllText(pathActual, sb.ToString().Trim());

            string expectedResult = string.Join("\r\n", File.ReadAllText(pathActual));
            string[] expectedResultArray = expectedResult.Split("\r\n").ToArray();

            expectedResultArray = expectedResultArray
                 .OrderByDescending(x => int.Parse(x.Split().Last()))
                 .ToArray();

            int isEqual = string.Join("\r\n", expectedResultArray)
                        .CompareTo(File.ReadAllText(pathExpected));

            Console.WriteLine(isEqual);
        }
    }
}
