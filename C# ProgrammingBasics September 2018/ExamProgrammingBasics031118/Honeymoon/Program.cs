using System;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double cost = 0;
            double diff = 0;

            switch (name)
            {
                case "Cairo":
                    if (nightsCount <= 4)
                    {
                        cost = (nightsCount * 500 + 600) * 0.97;
                    }
                    else if (nightsCount <= 9)
                    {
                        cost = (nightsCount * 500 + 600) * 0.95;
                    }
                    else if (nightsCount <= 24)
                    {
                        cost = (nightsCount * 500 + 600) * 0.90;
                    }
                    else if (nightsCount <= 49)
                    {
                        cost = (nightsCount * 500 + 600) * 0.83;
                    }
                    else
                    {
                        cost = (nightsCount * 500 + 600) * 0.70;
                    }
                    break;

                case "Paris":
                    if (nightsCount <5)
                    {
                        cost = nightsCount * 300 + 350;
                    }
                    else if (nightsCount >= 5 && nightsCount <= 9)
                    {
                        cost = (nightsCount * 300 + 350) * 0.93;
                    }
                    else if (nightsCount <= 24)
                    {
                        cost = (nightsCount * 300 + 350) * 0.88;
                    }
                    else if (nightsCount <= 49)
                    {
                        cost = (nightsCount * 300 + 350) * 0.78;
                    }
                    else
                    {
                        cost = (nightsCount * 300 + 350) * 0.70;
                    }
                    break;

                case "Lima":
                    if (nightsCount < 25)
                    {
                        cost = nightsCount * 800 + 850;
                    }
                    else if (nightsCount >= 25 && nightsCount <= 49)
                    {
                        cost = (nightsCount * 800 + 850) * 0.81;
                    }
                    else
                    {
                        cost = (nightsCount * 800 + 850) * 0.70;
                    }
                    break;

                case "New York":
                    if (nightsCount <= 4)
                    {
                        cost = (nightsCount * 600 + 650) * 0.97;
                    }
                    else if (nightsCount <= 9)
                    {
                        cost = (nightsCount * 600 + 650) * 0.95;
                    }
                    else if (nightsCount <= 24)
                    {
                        cost = (nightsCount * 600 + 650) * 0.88;
                    }
                    else if (nightsCount <= 49)
                    {
                        cost = (nightsCount * 600 + 650) * 0.81;
                    }
                    else
                    {
                        cost = (nightsCount * 600 + 650) * 0.70;
                    }
                    break;

                case "Tokyo":
                    if (nightsCount <10)
                    {
                        cost = nightsCount * 700 + 700;
                    }
                    else if (nightsCount >= 10 && nightsCount <= 24)
                    {
                        cost = (nightsCount * 700 + 700) * 0.88;
                    }
                    else if (nightsCount <= 49)
                    {
                        cost = (nightsCount * 700 + 700) * 0.83;
                    }
                    else
                    {
                        cost = (nightsCount * 700 + 700) * 0.70;
                    }
                    break;
            }
            if (cost <= budget)
            {
                diff = budget - cost;
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                diff = cost - budget;
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }

        }
    }
}
