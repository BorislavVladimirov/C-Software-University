using System;
using System.IO;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialFolrderPath = @"C:\users";
            var rootLevelFolders = Directory.GetDirectories(initialFolrderPath);

            for (int currentDirectoryIndex = 0; currentDirectoryIndex < rootLevelFolders.Length; currentDirectoryIndex++)
            {
                Console.WriteLine($"-------{rootLevelFolders[currentDirectoryIndex]}");

                var subfolders = Directory.GetDirectories(rootLevelFolders[currentDirectoryIndex]);

                for (int currSubDirIndex = 0; currSubDirIndex < subfolders.Length; currSubDirIndex++)
                {
                    Console.WriteLine($"----- {subfolders[currSubDirIndex]}");
                }
            }

            
        }
    }
}
