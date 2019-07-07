using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            int houseIndex = 0;

            while (command != "Merry Xmas!")
            {
                string[] input = command.Split();

                int jumpLength = int.Parse(input[1]);

                while (jumpLength != 0)
                {
                    if (houseIndex + 1 < houses.Count)
                    {
                        houseIndex++;
                        jumpLength--;
                    }
                    else
                    {
                        houseIndex = 0;
                        jumpLength--;
                    }
                }

                if (houses[houseIndex] == 0)
                {
                    Console.WriteLine($"House {houseIndex} will have a Merry Christmas.");
                }
                else
                {
                    houses[houseIndex] -= 2;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {houseIndex}.");

            if (IsMisionSucsesfull(houses))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                // int failedHousesCount = houses.Where(x => x != 0).Count();

                int failedHousesCount = GetFailedHousesCount(houses);

                Console.WriteLine($"Santa has failed {failedHousesCount} houses.");
            }
        }

        private static int GetFailedHousesCount(List<int> houses)
        {
            int failedCount = 0;

            foreach (var house in houses)
            {
                if (house != 0)
                {
                    failedCount++;
                }
            }
            return failedCount;
        }

        private static bool IsMisionSucsesfull(List<int> houses)
        {
            bool isTrue = true;

            foreach (var house in houses)
            {
                if (house != 0)
                {
                    isTrue = false;
                    break;
                }
            }

            return isTrue;
        }
    }
}
