using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalMoney = currentBalance;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                string nameOfGame = input;
                double price = 0;

                switch (nameOfGame)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition":price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        input = Console.ReadLine();
                        continue;
                }
                double diff = currentBalance - price;

                if (diff < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= price;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }            


                input = Console.ReadLine();

            }
            double totalMoneySpent = totalMoney - currentBalance;
            Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
