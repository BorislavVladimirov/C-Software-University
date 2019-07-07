using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int teddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int totalOrdersCount = puzzlesCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;
            double totalPrice = puzzlesCount * 2.60 + dollsCount * 3 + teddyBearsCount * 4.10 + minionsCount * 8.20 + trucksCount * 2;

            if (totalOrdersCount >= 50 )
            {
                double moneyEarned = totalPrice * 0.75;
                double moneyLeftAfterRent = moneyEarned * 0.9;

                if (moneyLeftAfterRent >= tripPrice ) 
                {
                    double moneyLeft = moneyLeftAfterRent - tripPrice;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeeded = tripPrice - moneyLeftAfterRent;
                    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
                }
            }
            else
            {
                double moneyEarned = totalPrice * 0.9;

                if (moneyEarned >= tripPrice)
                {
                    double moneyLeft = moneyEarned - tripPrice;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeeded = tripPrice - moneyEarned;
                    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
                }
            }
        }
    }
}
