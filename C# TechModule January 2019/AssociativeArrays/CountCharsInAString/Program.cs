using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArr = words[i].ToCharArray();

                foreach (var item in charArr)
                {
                    if (!chars.ContainsKey(item))
                    {
                        chars[item] = 0;
                    }
                    chars[item]++;
                }
            }   

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
