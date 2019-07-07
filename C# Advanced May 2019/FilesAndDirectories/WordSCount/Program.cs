using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (var reader = new StreamReader(Path.Combine("Files", "words.txt")))
            {
                string[] line = reader.ReadLine().Split();

                for (int i = 0; i < line.Length; i++)
                {
                    string currentword = line[i].ToString().ToLower();

                    if (!wordCount.ContainsKey(currentword))
                    {
                        wordCount.Add(currentword, 0);
                    }
                }
            }
            using (var reader = new StreamReader(Path.Combine("Files", "text.txt")))
            {
                string textLine = reader.ReadLine();

                while (textLine != null)
                {
                    string[] lineToarr = textLine.Trim(new char[] { ',', '-', '?', '!', '@', ' ', '.' })
                        .Split(new char[] { ',', '-', '?', '!', '@', ' ', '.' });

                    foreach (var word in lineToarr.Select(x => x.ToLower()))
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                    }

                    textLine = reader.ReadLine();
                }
            }
            using (var writer = new StreamWriter(Path.Combine("Files", "output.txt")))
            {
                foreach (var word in wordCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
