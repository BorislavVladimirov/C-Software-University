using System;
using System.Numerics;

namespace ConsoleApp1
{  

    namespace SnowBalls
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                BigInteger hightestResut = 0;
                int snowballSnow = 0;
                int snowballTime = 0;
                int snowballQuality = 0;
                BigInteger snowballValue2 = 0;

                int a = 0;
                int b = 0;
                int c = 0;

                for (int i = 0; i < n; i++)
                {
                    snowballSnow = int.Parse(Console.ReadLine());
                    snowballTime = int.Parse(Console.ReadLine());
                    snowballQuality = int.Parse(Console.ReadLine());

                    BigInteger snowballValue = (snowballSnow / snowballTime);

                    snowballValue2 = BigInteger.Pow(snowballValue, snowballQuality);

                    if (snowballValue2 > hightestResut)
                    {
                        hightestResut = snowballValue2;
                        a = snowballSnow;
                        b = snowballTime;
                        c = snowballQuality;
                    }
                }
                Console.WriteLine($"{a} : {b} = {hightestResut} ({c})");


            }
        }
    }

}
