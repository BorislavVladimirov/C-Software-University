using System;
using System.Numerics;
namespace snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger bestSnowball = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow(((snowballSnow / snowballTime)), snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    a = snowballSnow;
                    b = snowballTime;
                    c = snowballQuality;
                }
            }
            Console.WriteLine($"{a} : {b} = {bestSnowball} ({c})");
        }
    }
}
