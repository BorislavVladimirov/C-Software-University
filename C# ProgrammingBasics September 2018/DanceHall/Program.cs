using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double totalHallArea = (l * 100) * (w * 100);
            double wardrobeArea = (a * 100 ) * ( a * 100);
            double benchArea = totalHallArea / 10;  
            double FreeHallArea = totalHallArea - wardrobeArea - benchArea;
            double dancersCount = FreeHallArea / (40 + 7000);


            Console.WriteLine(Math.Floor(dancersCount));
        }
    }
}
