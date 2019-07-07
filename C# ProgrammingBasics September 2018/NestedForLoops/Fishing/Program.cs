using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quata = int.Parse(Console.ReadLine());

            double profit = 0;
            double lost = 0;

            double fishCounter = 0;

            string fishName = "";

            while ((fishName = Console.ReadLine()) != "Stop")
            {
                double currentFishPrice = 0;
                double fishKg = double.Parse(Console.ReadLine());
                fishCounter++;                

                if (fishCounter % 3 == 0)
                {
                    for (int i = 0; i < fishName.Length; i++)
                    {
                        currentFishPrice += fishName[i];
                    }
                    profit += currentFishPrice / fishKg;

                }
                else
                {
                    for (int i = 0; i < fishName.Length; i++)
                    {
                        currentFishPrice += fishName[i];
                    }
                    lost += currentFishPrice / fishKg;
                }
                if (fishCounter == quata)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }
            if (profit > lost)
            {
                Console.WriteLine($"Lyubo's profit from {fishCounter} fishes is {profit-lost:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {lost - profit:f2} leva today.");
            }
        }
    }
}
