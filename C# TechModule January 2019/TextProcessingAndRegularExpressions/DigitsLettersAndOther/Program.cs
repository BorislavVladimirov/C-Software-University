using System;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];

                if (char.IsDigit(temp))
                {
                    Console.Write(temp);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];

                if (char.IsLetter(temp))
                {
                    Console.Write(temp);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];

                if (!char.IsDigit(temp) && !char.IsLetter(temp))
                {
                    Console.Write(temp);
                }
            }
        }
    }
}
