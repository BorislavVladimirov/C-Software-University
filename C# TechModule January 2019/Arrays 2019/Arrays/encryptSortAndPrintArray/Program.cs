using System;
using System.Linq;
using System.Text;

namespace encryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] result = new int[numberOfLines];
            int[] ordered = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                string name = Console.ReadLine();

                byte[] asciBytes = Encoding.ASCII.GetBytes(name);

                double sumOfAscii = 0;

                foreach (var item in asciBytes)
                {
                    if (item == 97 || item == 101 || item == 105 || item == 111
                        || item == 117 || item == 65
                        || item == 69 || item == 73 || item == 79 || item == 85)
                    {
                        sumOfAscii += item * name.Length;
                    }
                    else
                    {
                        sumOfAscii += item / name.Length;
                    }
                }
                result[i] = (int)sumOfAscii;
                ordered = result.OrderBy(x => x).ToArray();
            }
            foreach (var item in ordered)
            {
                Console.Write(item);
                Console.WriteLine();
            }
        }
    }
}
