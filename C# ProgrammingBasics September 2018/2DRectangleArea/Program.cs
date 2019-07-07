using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y1 - y2);
            double area = a * b;
            double perim = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(perim);
        }
    }
}
