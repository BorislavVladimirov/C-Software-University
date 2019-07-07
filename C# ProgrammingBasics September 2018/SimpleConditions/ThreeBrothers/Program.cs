using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / a + 1 / b + 1 / c);
            double totalTimeWithBreak = totalTime + totalTime * 0.15;
            double timeLeft = d - totalTimeWithBreak;

            if (timeLeft > 0)
            {
                Console.WriteLine($"Cleaning time: {totalTimeWithBreak:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else if (timeLeft <= 0)
            {
                double shortage = totalTimeWithBreak - d;
                Console.WriteLine($"Cleaning time: {totalTimeWithBreak:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(shortage)} hours.");
            }
        }
    }
}
