using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"Line Numbers\Input.txt"))
            {
                var line = reader.ReadLine();
                int count = 1;

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{count}. {line}");
                        count++;
                        line = reader.ReadLine();                          
                    }
                }
            }
        }
    }
}
