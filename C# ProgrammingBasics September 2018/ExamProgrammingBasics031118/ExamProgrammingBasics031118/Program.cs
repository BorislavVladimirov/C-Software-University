using System;

namespace ExamProgrammingBasics031118
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtOfHall = double.Parse(Console.ReadLine());
            double wightOfHall = double.Parse(Console.ReadLine());
            double sideOfBar = double.Parse(Console.ReadLine());

            double totalHallArea = lenghtOfHall * wightOfHall;
            double totalBarArea = sideOfBar * sideOfBar;
            double dancingArea = totalHallArea * 0.19;

            double totalGuestCount = (totalHallArea - totalBarArea - dancingArea) / 3.2;

            Console.WriteLine($"{Math.Ceiling(totalGuestCount)}");
            
        }
    }
}
