using System;

namespace test
{
    class Program
    {
        public delegate void Print(int x);
        static void Main(string[] args)
        {
            Print printnumber = PrintNumber;
            printnumber(12);

            Print printString = PrintNumberAsString;
        }
        static void PrintNumber(int x)
        {
            Console.WriteLine(x + 1);
        }
        static void PrintNumberAsString(int x)
        {
            Console.WriteLine($"{x} - string");
        }
    }
}
