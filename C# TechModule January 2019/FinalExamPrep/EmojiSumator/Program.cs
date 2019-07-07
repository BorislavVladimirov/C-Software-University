using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EmojiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int emojiCode = Console.ReadLine().Split(":").ToArray().Sum(x => int.Parse(x));

            Dictionary<string, int> sums = new Dictionary<string, int>();

            string pattern = @"[ ]\:[a-z]{4,}\:[ ]";

            //string[] tempInput = input.Split(new char[] { ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);           

            int currentEmojiCodeSum = 0;
            int totalSum = 0;
            
            foreach (var match in Regex.Matches(input,pattern))
            {                
                currentEmojiCodeSum = match.ToString().TrimEnd(':').TrimStart(':').Sum(x => x);

                sums.Add(match.ToString(), currentEmojiCodeSum);

                totalSum += currentEmojiCodeSum;
            }

            if (sums.ContainsValue(emojiCode))
            {
                totalSum *= 2;
            }
            if (sums.Count != 0)
            {
                Console.Write("Emojis found: ");
            }

            foreach (var item in sums)
            {
                Console.WriteLine(string.Join(", ",item.Key));
            }

            Console.WriteLine($"Total Emoji Power: {totalSum}");

        }
    }
}
