using System;
using System.Linq;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!(currentChar >= 'd' && currentChar < 126 || currentChar == 35))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }

            string[] substring = Console.ReadLine().Split();

            string stringToReplace = substring[0];
            string ReplaceString = substring[1];

            string temp = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                temp += (char)(input[i] - 3);
            }

            while (temp.Contains(stringToReplace))
            {
                temp = temp.Replace(stringToReplace, ReplaceString);
            }
            Console.WriteLine(temp);
        }
    }
}
