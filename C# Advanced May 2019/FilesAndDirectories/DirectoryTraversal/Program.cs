using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileArray = Directory.GetFiles(".", "*.*;");

            Dictionary<string, Dictionary<string, double>> dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach (var currentFile in allFiles)
            {
                double size = (currentFile.Length / 1024d);
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }

            var sortedDictionary = dirInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach (var item in sortedDictionary)
            {
                File.AppendAllText(savePath, item.Key + Environment.NewLine);

                foreach (var file in item.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(savePath, $"--{file.Key} - {Math.Round(file.Value)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
