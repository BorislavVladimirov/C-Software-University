using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToBan = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var banWord in wordsToBan)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
