using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermansCount = int.Parse(Console.ReadLine());

            int rentForShip = 0;
            double price = 0;
            double moneyLeft = 0;

            if (season == "Spring")
            {
                rentForShip = 3000;

                if (fishermansCount <= 6)
                {
                    price = rentForShip * 0.9;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    price = rentForShip * 0.85;
                }
                else if (fishermansCount >= 12)
                {
                    price = rentForShip * 0.75;
                }
                if (fishermansCount % 2 == 0)
                {
                    price = price * 0.95;
                }
                moneyLeft = budget - price;
            }
            else if (season == "Summer")
            {
                rentForShip = 4200;

                if (fishermansCount <= 6)
                {
                    price = rentForShip * 0.9;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    price = rentForShip * 0.85;
                }
                else if (fishermansCount >= 12)
                {
                    price = rentForShip * 0.75;
                }
                if (fishermansCount % 2 == 0)
                {
                    price = price * 0.95;
                }
                moneyLeft = budget - price;
            }
            else if (season == "Autumn")
            {
                rentForShip = 4200;

                if (fishermansCount <= 6)
                {
                    price = rentForShip * 0.9;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    price = rentForShip * 0.85;
                }
                else if (fishermansCount >= 12)
                {
                    price = rentForShip * 0.75;
                }
                moneyLeft = budget - price;
            }
            else if (season == "Winter")
            {
                rentForShip = 2600;

                if (fishermansCount <= 6)
                {
                    price = rentForShip * 0.9;
                }
                else if (fishermansCount >= 7 && fishermansCount <= 11)
                {
                    price = rentForShip * 0.85;
                }
                else if (fishermansCount >= 12)
                {
                    price = rentForShip * 0.75;
                }
                if (fishermansCount % 2 == 0)
                {
                    price = price * 0.95;
                }
                moneyLeft = budget - price;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }
        }
    }
}
