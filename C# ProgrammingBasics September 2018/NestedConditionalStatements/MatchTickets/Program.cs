using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double budgetLeft = 0;

            if (people >= 1 && people <= 4)
            {
                budgetLeft = budget * 0.25;
            }
            else if (people >= 5 && people <= 9)
            {
                budgetLeft = budget * 0.4;
            }
            else if (people >= 10 && people <= 24)
            {
                budgetLeft = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                budgetLeft = budget * 0.6;
            }
            else if (people >= 50)
            {
                budgetLeft = budget * 0.75;
            }

            if (category == "VIP")
            {
                double price = 499.99 * people;

                if (budgetLeft >= price)
                {
                    double moneyLeft = budgetLeft - price;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");

                }
                else if (budgetLeft < price)
                {
                    double moneyNeeded = price - budgetLeft;
                    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):f2} leva.");
                }
            }
            else if (category == "Normal")
            {
                double price = 249.99 * people;

                if (budgetLeft >= price)
                {
                    double moneyLeft = budgetLeft - price;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");

                }
                else if (budgetLeft < price)
                {
                    double moneyNeeded = price - budgetLeft;
                    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):f2} leva.");
                }
            }
        }
    }
}
