using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (char.IsUpper(a))
            {
                Console.WriteLine("upper-case");
                return;
            }
            Console.WriteLine("lower-case");


        }
    }
}
