using System;

namespace ProblemSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                //int startIndex = text.IndexOf(stringToRemove);
                //text = text.Remove(startIndex, stringToRemove.Length);

                text = text.Replace(stringToRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}
