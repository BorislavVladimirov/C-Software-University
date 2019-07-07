using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new SortedDictionary<string, List<string>>();

            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string thirdString = Console.ReadLine();

            string[] firstStringToArr = firstString.Split(" | ");

            for (int i = 0; i < firstStringToArr.Length; i++)
            {
                string[] tempPair = firstStringToArr[i].Split(": ");

                string word = tempPair[0];
                string definition = tempPair[1];

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(definition);
                }
                else
                {
                    words[word].Add(definition);
                }                
            }
            string[] secondStringToArr = secondString.Split(" | ");
            List<string> secondStringWords = new List<string>();

            for (int i = 0; i < secondStringToArr.Length; i++)
            {
                string word = secondStringToArr[i];

                secondStringWords.Add(word);
            }
            foreach (var kvp in words)
            {
                if (secondStringWords.Contains(kvp.Key))
                {
                    Console.WriteLine($"{kvp.Key}");

                    foreach (var item in kvp.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{item}");
                    }
                }
            }
            if (thirdString == "End")
            {
                return;
            }
            if (thirdString == "List")
            {
                List<string> tempArr = new List<string>();

                foreach (var word in words.OrderBy(x => x.Key))
                {
                    tempArr.Add(word.Key);
                }
                Console.WriteLine(string.Join(" ", tempArr));
            }

        }
    }
}
