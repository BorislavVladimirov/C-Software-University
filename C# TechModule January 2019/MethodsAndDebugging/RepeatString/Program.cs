using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertedString(text, number));
        }
        static string ConvertedString(string text, int number)
        {
            string compilatedString = string.Empty;

            for (int i = 0; i < number; i++)
            {
                compilatedString += text;
            }
            return compilatedString;
        }
    }
}
