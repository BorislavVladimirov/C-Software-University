using System;

namespace vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            PrintingCountOfVowels(input);

        }

        private static void PrintingCountOfVowels(string input)
        {
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];


                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'o' ||
                    currentChar == 'i' || currentChar == 'u' )
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
