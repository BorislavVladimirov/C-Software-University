using System;

namespace WeddingDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double moneySpent = 0;
            int balloonscount = 0;
            int flowerscount = 0;
            int candlescount = 0;
            int ribbonsLengh = 0;
            double moneyLeft = 0;

            double begginingBudget = budget;

            while (input != "stop")
            {
                int count = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case "balloons":
                        budget -= 0.1 * count;
                        moneySpent += 0.1 * count;
                        balloonscount += count;
                        break;
                    case "flowers":
                        budget -= 1.50 * count;
                        moneySpent += 1.50 * count;
                        flowerscount += count;
                        break;
                    case "candles":
                        budget -= 0.50 * count;
                        moneySpent += 0.50 * count;
                        candlescount += count;
                        break;
                    case "ribbon":
                        budget -= 2 * count;
                        moneySpent += 2 * count;
                        ribbonsLengh += count;
                        break;

                }
                if (budget <= 0)
                {
                    Console.WriteLine($"All money is spent!");
                    Console.WriteLine($"Purchased decoration is {balloonscount} balloons, {ribbonsLengh} m ribbon, {flowerscount} flowers and {candlescount} candles.");
                    return;
                }

                input = Console.ReadLine();

            }
            moneyLeft = begginingBudget - moneySpent;

            Console.WriteLine($"Spend money: {moneySpent:f2}");
            Console.WriteLine($"Money left: {moneyLeft:f2}");
            Console.WriteLine($"Purchased decoration is {balloonscount} balloons, {ribbonsLengh} m ribbon, {flowerscount} flowers and {candlescount} candles.");
        }
    }
}
