using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;

            foreach (var character in text)
            {
                result += (char)(character + 3);
            }

            Console.WriteLine(result);
        }
    }
}
