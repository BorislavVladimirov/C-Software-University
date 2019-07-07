using System;

namespace OddPowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i+=2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
