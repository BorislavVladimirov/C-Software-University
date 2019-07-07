using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            string firstWord = tokens[0];
            string secondWord = tokens[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            int sum = 0;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }
            for (int i = 0; i < shorterWord.Length; i++)
            {
                sum += longerWord[i] * shorterWord[i];
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }

            Console.WriteLine(sum);
        }
    }
}
