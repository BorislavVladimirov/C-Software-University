using System;

namespace decryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            char[] arr = new char[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char newChar = (char)(character + key);

                arr[i] = newChar;
            }

            Console.WriteLine(string.Join("",arr));

            string[] test = new string[5];
            Console.WriteLine(string.Join("",test));
        }
    }
}
