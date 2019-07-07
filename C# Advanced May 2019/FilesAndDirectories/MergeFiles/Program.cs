using System;
using System.Collections.Generic;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> mergedFiles = new List<int>();

            using (var reader = new StreamReader(Path.Combine("Files", "FileOne.txt")))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    mergedFiles.Add(int.Parse(line));
                    line = reader.ReadLine();
                }
            }
            using (var secondFileReader = new StreamReader(Path.Combine("Files", "FileTwo.txt")))
            {
                string secondLine = secondFileReader.ReadLine();

                while (secondLine != null)
                {
                    mergedFiles.Add(int.Parse(secondLine));
                    secondLine = secondFileReader.ReadLine();
                }
            }
            mergedFiles.Sort();

            using (var writer = new StreamWriter(Path.Combine("Files", "Output.txt")))
            {
                foreach (var item in mergedFiles)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
