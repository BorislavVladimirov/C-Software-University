using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal hightestResut = 0;

            int Snow = 0;
            int Time = 0;
            int Quality = 0;
            decimal value = 0;

            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                Snow = int.Parse(Console.ReadLine());
                Time = int.Parse(Console.ReadLine());
                Quality = int.Parse(Console.ReadLine());

                value = Snow / Time;
                decimal temp = value;

                for (int y = 1; y < Quality; y++)
                {
                    value *= temp;
                }

                if (value > hightestResut)
                {
                    hightestResut = value;
                    a = Snow;
                    b = Time;
                    c = Quality;
                }
            }
            Console.WriteLine($"{a} : {b} = {hightestResut} ({c})");


        }
    }
}
