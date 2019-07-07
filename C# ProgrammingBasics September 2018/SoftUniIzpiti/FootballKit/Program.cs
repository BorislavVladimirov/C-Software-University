using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double shoesPrice = (tshirtPrice + shortsPrice) * 2;
            double totalCost = (tshirtPrice + shortsPrice + socksPrice + shoesPrice) * 0.85;

            if (totalCost >= sumNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalCost:f2} lv.");
            }
            else
            {
                double diff = sumNeeded - totalCost;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {diff:f2} lv. more.");
            }
        }
    }
}
