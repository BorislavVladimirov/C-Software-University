using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggestDevider = int.MinValue;      
            
            
            
             if (number % 10 == 0)
            {
                if (10 > biggestDevider)
                {
                    biggestDevider = 10;
                }
            }
            else if (number % 7 == 0)
            {
                if (7 > biggestDevider)
                {
                    biggestDevider = 7;
                }
            }
            else if (number % 6 == 0)
            {
                if (6 > biggestDevider)
                {
                    biggestDevider = 6;
                }
            }
            else if (number % 3 == 0)
            {
                if (3 > biggestDevider)
                {
                    biggestDevider = 3;
                }
            }
            else if (number % 2 == 0)
            {
                if (2 > biggestDevider)
                {
                    biggestDevider = 2;
                }
            }
            else
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {biggestDevider}");

        }
    }
}
