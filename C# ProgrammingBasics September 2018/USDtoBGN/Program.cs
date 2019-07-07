using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double BGN = n * 1.79549;
            Console.WriteLine($"{BGN:f2}");
        }
    }
}
