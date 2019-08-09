using System;

namespace EnterNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            ReadNumber(start, end);
        }

        private static void ReadNumber(int start, int end)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    string input = Console.ReadLine();

                    int num = int.Parse(input);

                    if (num < start || num > end)
                    {
                        Console.WriteLine("The integer number was outside the range!");
                        ReadNumber(start, end);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number!");

                ReadNumber(start, end);
            }
        }
    }
}
