using System;

namespace lowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char newChar = char.Parse(Console.ReadLine());

            if (newChar >= 97 && newChar <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if (newChar >= 65 && newChar <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
