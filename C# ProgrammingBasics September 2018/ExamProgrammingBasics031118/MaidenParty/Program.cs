using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyCost = double.Parse(Console.ReadLine());
            int countLoveMassages = int.Parse(Console.ReadLine());
            int countWaxRoses = int.Parse(Console.ReadLine());
            int countKeyholders = int.Parse(Console.ReadLine());
            int countCartoons = int.Parse(Console.ReadLine());
            int countSurprises = int.Parse(Console.ReadLine());

            double totalIncome = (countLoveMassages * 0.60) + (countWaxRoses * 7.2) + (countKeyholders * 3.60) + (countCartoons * 18.20) + (countSurprises * 22);

            if (countLoveMassages + countWaxRoses + countKeyholders + countCartoons + countSurprises >= 25)
            {
                totalIncome = totalIncome * 0.65;
            }
            totalIncome = totalIncome * 0.9;
            if (totalIncome >= partyCost)
            {
                double diff = totalIncome - partyCost;
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                double diff = partyCost - totalIncome;
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }


        }
    }
}
