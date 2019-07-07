using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeter = int.Parse(Console.ReadLine());

            Console.WriteLine($"{distanceInMeter*1.0/1000:f2}");
        }
    }
}
