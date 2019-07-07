using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade > 6)
            {
                Console.WriteLine("Warning! Your input exceed the maximum allowed number!");
            }
            if (grade < 2)
            {
                Console.WriteLine("Warning! Your input is lower than the minimum");
            }
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
