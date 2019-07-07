using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSecods = double.Parse(Console.ReadLine());

            double totalTime = (distance * timeInSecods);
            double slowTime = Math.Floor(distance / 15) * 12.5;

            double IvanchoRecord = totalTime + slowTime;

            double succes = IvanchoRecord - record;

            if (IvanchoRecord < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanchoRecord:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(succes):f2} seconds slower.");
            }             
        }
    }
}
