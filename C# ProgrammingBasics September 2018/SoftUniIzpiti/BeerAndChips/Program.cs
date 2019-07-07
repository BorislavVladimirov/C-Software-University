using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double BeersMoney = beerCount * 1.2;
            double chipsMoney = BeersMoney * 0.45;
            double totalChipsPrice = Math.Ceiling(chipsCount * chipsMoney);
            double totalMoney = totalChipsPrice + BeersMoney;
            double moneyLeft = budget - totalMoney;
            

            if (budget >= totalMoney)
            {
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(moneyLeft):f2} more leva!");
            }
        }
    }
}
