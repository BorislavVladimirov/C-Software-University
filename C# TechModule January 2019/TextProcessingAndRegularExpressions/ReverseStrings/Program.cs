using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string result = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += input[i];
                }
                Console.WriteLine($"{input} = {result}");

                input = Console.ReadLine();
            }
        }
    }
}
