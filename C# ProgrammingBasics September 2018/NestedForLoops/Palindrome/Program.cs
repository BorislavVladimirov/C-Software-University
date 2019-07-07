using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (int i = 97; i <= 122; i++)
            {
                for (int j = 97; j <= 122; j++)
                {
                    for (int k = 97; k <= 122; k++)
                    {
                        if (i == k )
                        {
                            char a = (char)i;
                            char b = Convert.ToChar(j);
                            char c = Convert.ToChar(k);
                            Console.WriteLine($"{a}{b}{c}");
                        }
                    }
                }
            }
        }
    }
}
