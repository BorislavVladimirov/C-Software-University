using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());   
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine(CalculateArea(a, b));
        }
        static int CalculateArea (int a , int b)
        {
            int result = a * b;
            return result;            
        }

    }
}
