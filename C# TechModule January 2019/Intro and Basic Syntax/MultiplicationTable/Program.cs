using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} X {a} = {a * number}");
                a++;
            }
        }
    }
}
