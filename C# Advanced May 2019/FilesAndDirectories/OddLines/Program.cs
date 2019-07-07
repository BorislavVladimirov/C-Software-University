using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "Odd Lines";
            string fileName = "Input.txt";
            string filePath = Path.Combine(path, fileName);

            using (var reader = new StreamReader(filePath))
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {                     
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
