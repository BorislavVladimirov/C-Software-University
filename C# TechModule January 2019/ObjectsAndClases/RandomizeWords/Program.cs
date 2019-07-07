using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();
            var random = new Random();
            var shuffledWords = new List<string>();

            foreach (var word in words)
            {
                int newIndex = random.Next(0, shuffledWords.Count + 1);
                shuffledWords.Insert(newIndex, word);
            }

            foreach (var item in shuffledWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
