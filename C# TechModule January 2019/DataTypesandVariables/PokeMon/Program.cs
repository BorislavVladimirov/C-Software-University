using System;
using System.Numerics;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            BigInteger halfOfN = n /2;

            int count = 0;

            while (n >= m)
            {
                n -= m;
                count++;

                if (n == halfOfN)
                {
                    if (y != 0)
                    {
                        n /= y;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
