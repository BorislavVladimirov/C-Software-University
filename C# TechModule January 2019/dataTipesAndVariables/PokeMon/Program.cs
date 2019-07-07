using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pokePower = n / 2;
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());
            int targetsPokedCount = 0;

            while (n >= m)
            {
                n -= m;
                targetsPokedCount++;

                if (n == pokePower)
                {
                    if (y > 0)
                    {
                        n /= y;
                    } 
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsPokedCount);
        }
    }
}
