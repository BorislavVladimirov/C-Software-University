using System;

namespace calculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());
            double area = RectangleArea(width, height);

            Console.WriteLine(area);
        }

        private static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
