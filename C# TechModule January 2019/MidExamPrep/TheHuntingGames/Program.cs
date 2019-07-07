using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnegy = double.Parse(Console.ReadLine());
            double totalwaterSupplies = double.Parse(Console.ReadLine()) * playersCount * days;
            double totalFoodSupplies = double.Parse(Console.ReadLine()) * playersCount * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                groupEnegy -= energyLoss;

                if (groupEnegy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFoodSupplies:f2} food and {totalwaterSupplies:f2} water.");
                    return;
                }
                if (i % 2 == 0)
                {
                    groupEnegy *= 1.05;
                    totalwaterSupplies -= totalwaterSupplies * 0.3;
                }
                if (i % 3 == 0)
                {
                    totalFoodSupplies -= totalFoodSupplies / playersCount;
                    groupEnegy *= 1.1;
                }

            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnegy:f2} energy!");
        }
    }
}
