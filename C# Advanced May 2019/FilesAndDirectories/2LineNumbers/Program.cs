using System;
using System.IO;
using System.Linq;

namespace _2LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(Path.Combine("Files", "text.txt"));

            int lineCouint = 0;

            foreach (var line in lines)
            {
                int puncMarksCount = 0;
                int letterCount = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsPunctuation(line[i]))
                    {
                        puncMarksCount++;
                    }
                    if (char.IsLetter(line[i]))
                    {
                        letterCount++;
                    }
                }
                File.AppendAllText("output.txt", $"Line {++lineCouint}: {line} ({letterCount})({puncMarksCount})" + Environment.NewLine);
            }
        }
    }
}
