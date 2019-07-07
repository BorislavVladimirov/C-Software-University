using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            if (word.Equals(secondWord))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
