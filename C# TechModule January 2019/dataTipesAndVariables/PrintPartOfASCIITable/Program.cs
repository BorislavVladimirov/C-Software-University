using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingChar = int.Parse(Console.ReadLine());
            int endingChar = int.Parse(Console.ReadLine());

            for (int i = startingChar; i <= endingChar; i++)
            {
                char character = (char)i;
                Console.Write($"{character} ");
            }
            Console.WriteLine();
        }
    }
}
