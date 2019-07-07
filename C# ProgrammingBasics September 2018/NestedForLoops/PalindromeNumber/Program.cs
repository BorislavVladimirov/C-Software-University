using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (num < 100 && num > 10)
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (i == j)
                        {
                            Console.WriteLine($"{i}{j}");
                        }
                    }
                }
            }
            else if (num < 1000 && num > 100)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            if (i == k)
                            {
                                if (i > 1000 || k > 1000)
                                {
                                    return;
                                }
                                Console.WriteLine($"{i}{j}{k}");
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        for (int k = 0; k < 10000; k++)
                        {
                            for (int l = 0; l < 10000; l++)
                            {
                                Console.WriteLine($"{i}{j}{k}{l}");
                            }
                        }
                    }
                }
                return;
            }
            }
    }
}
