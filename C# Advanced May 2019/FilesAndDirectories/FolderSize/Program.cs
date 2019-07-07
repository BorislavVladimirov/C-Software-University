using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"D:\Coding\Coding\C#\C# Advanced May 2019\FilesAndDirectories\FolderSize\TestFolder");

            double totalSize = 0;

            foreach (var fileIno in dir.GetFiles())
            {
                totalSize += fileIno.Length;
            }
            totalSize = totalSize / 1024 / 1024;

            File.WriteAllText("Output.txt", totalSize.ToString());
        }
    }
}
