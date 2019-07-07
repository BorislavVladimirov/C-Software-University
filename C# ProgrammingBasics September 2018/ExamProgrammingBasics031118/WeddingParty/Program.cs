using System;

namespace WeddingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int totalPrice = guestsCount * 20;
            double moneyLeft = budget - totalPrice;
            double moneyForFireworks = 0;
            double moneyForCharity = 0;

            if (totalPrice <= budget)
            {
                moneyForFireworks = moneyLeft * 0.4;
                moneyForCharity = moneyLeft - moneyForFireworks;
                Console.WriteLine($"Yes! {Math.Round(moneyForFireworks)} lv are for fireworks and {Math.Round(moneyForCharity)} lv are for donation.");
            }
            else
            {
                double diff = totalPrice - budget;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(diff)} lv more.");
            }


        }
    }
}
