using System;

namespace DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int health = 100;
            int coins = 0;

            string[] rooms = Console.ReadLine().Split("|");

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] command = rooms[i].Split(" ");

                string input = command[0];
                int number = int.Parse(command[1]);

                switch (input)
                {
                    case "potion":

                        int pointsToheal = initialHealth - health;
                        if (number > pointsToheal)
                        {
                            health += pointsToheal;
                            Console.WriteLine($"You healed for {pointsToheal} hp.");
                        }
                        else
                        {
                            health += number;
                            Console.WriteLine($"You healed for {number} hp.");
                        }                        
                        Console.WriteLine($"Current health: {health} hp.");
                        break;

                    case "chest":
                        coins += number;
                        Console.WriteLine($"You found {number} coins.");
                        break;

                    default:

                        health -= number;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {input}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {input}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
