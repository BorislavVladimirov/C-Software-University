using System;
using System.Numerics;

namespace dataTipesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{meters / 1000f:f2}");

            
        }
    }
}
