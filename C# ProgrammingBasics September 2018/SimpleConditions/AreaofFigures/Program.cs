using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            double area = 0;

            if (typeOfFigure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (typeOfFigure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (typeOfFigure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                area = (a * a) * Math.PI;
            }
            else if (typeOfFigure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = (a * b) / 2;
            }
            Console.WriteLine($"{area:f3}");

        }
    }
}
