using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        public static void Main(string[] args)
        {

            int counter = 0;
            char[] toReplace = { '-', ',', '.', '!', '?' };

            using (var reader = new StreamReader(Path.Combine("Files", "text.txt")))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] temp = line.Split(new[] { ' ' });

                    temp = temp.Reverse().ToArray();

                    for (int i = 0; i < temp.Length; i++)
                    {
                        for (int y = 0; y < temp[i].Length; y++)
                        {
                            if (toReplace.Contains(temp[i][y]))
                            {
                               temp[i] = temp[i].Replace(temp[i].ElementAt(y), '@');
                            }                            
                        }
                    }

                    if (counter++ % 2 ==0)
                    {
                        Console.WriteLine(string.Join(" ", temp));
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
