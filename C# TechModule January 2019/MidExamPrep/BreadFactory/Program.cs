using System;

namespace BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;

            string[] workingDayEvents = Console.ReadLine().Split("|");

            for (int i = 0; i < workingDayEvents.Length; i++)
            {
                string[] events = workingDayEvents[i].Split("-");

                string command = events[0];
                int number = int.Parse(events[1]);

                switch (command)
                {
                    case "rest":
                        if (energy + number <= 100)
                        {
                            energy += number;
                            Console.WriteLine($"You gained {number} energy.");
                        }
                        else
                        {
                            Console.WriteLine($"You gained {0} energy.");
                        }
                        Console.WriteLine($"Current energy: {energy}.");
                        break;
                    case "order":
                        coins += number;
                        energy -= 30;
                        if (energy >= 0)
                        {
                            Console.WriteLine($"You earned {number} coins.");
                        }
                        else
                        {
                            energy += 30;
                            energy += 50;
                            coins -= number;
                            Console.WriteLine($"You had to rest!");
                        }
                        break;

                    default:
                        int ingredientPrice = number;
                        string ingredient = command;

                        coins -= ingredientPrice;
                        if (coins > 0)
                        {
                            Console.WriteLine($"You bought {ingredient}.");
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
