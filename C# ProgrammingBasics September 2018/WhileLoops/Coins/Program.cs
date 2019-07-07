using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double coins = Math.Round(change * 100);
            int coinsCount = 0;

            while (coins > 0)
            {
                if (coins >= 200)
                {
                    coinsCount++;
                    coins -= 200;
                }
                else if (coins < 200 && coins >= 100)
                {
                    coinsCount++;
                    coins -= 100;
                } 
                else if (coins < 100 && coins >= 50)
                {
                    coinsCount++;
                    coins -= 50;
                }
                else if (coins < 50 && coins >= 20)
                {
                    coinsCount++;
                    coins -= 20;
                }
                else if (coins < 20 && coins >= 10)
                {
                    coinsCount++;
                    coins -= 10;
                }
                else if (coins < 10 && coins >= 5)
                {
                    coinsCount++;
                    coins -= 5;
                }
                else if (coins < 5 && coins >= 2)
                {
                    coinsCount++;
                    coins -= 2;
                }
                else if (coins < 2)
                {
                    coinsCount++;
                    coins -= 1;
                }
            }
            Console.WriteLine(coinsCount);
        }
    }
}
