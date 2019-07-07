using System;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double totalVolume = lenght * wight * height;
            double totalWaterVolume = totalVolume * 0.001;
            double litersNeeded = totalWaterVolume * (1 - (percent * 0.01));

            Console.WriteLine($"{litersNeeded:f3}");

        }
    }
}
