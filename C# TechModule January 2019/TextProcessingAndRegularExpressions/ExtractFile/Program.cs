using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int startIndex = path.LastIndexOf('\\') + 1;
            string file = path.Substring(startIndex);

            int startIndexOfExtension = file.LastIndexOf('.') + 1;

            string name = file.Substring(0, startIndexOfExtension - 1);
            string extension = file.Substring(startIndexOfExtension);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
