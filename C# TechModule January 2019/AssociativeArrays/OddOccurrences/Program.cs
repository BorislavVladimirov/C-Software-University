using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();

                if (!counts.ContainsKey(wordToLower))
                {
                    counts[wordToLower] = 0;
                }

                counts[wordToLower]++;
            }
            foreach (var word in counts.Where( x =>  x.Value % 2 != 0))
            {
                Console.Write($"{word.Key} ");
            }
        }
    }
}
