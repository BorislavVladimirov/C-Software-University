using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopsToVisit = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];

                switch (command)
                {
                    case "Include":
                        string shop = input[1];
                        shopsToVisit.Add(shop);
                        break;

                    case "Visit":
                        string type = input[1];
                        int numberOfShops = int.Parse(input[2]);

                        if (type == "first" && numberOfShops <= shopsToVisit.Count)
                        {
                            shopsToVisit.RemoveRange(0, numberOfShops);
                        }
                        else if (type == "last" && numberOfShops <= shopsToVisit.Count)
                        {
                            int startingIndex = (shopsToVisit.Count - 1) - numberOfShops;
                            shopsToVisit.RemoveRange(startingIndex + 1, numberOfShops);
                        }
                        break;

                    case "Prefer":
                        int fisrtShopIndex = int.Parse(input[1]);
                        int secondShopIndex = int.Parse(input[2]);

                        if (fisrtShopIndex >= 0 && fisrtShopIndex <= shopsToVisit.Count - 1
                            && secondShopIndex >= 0 && secondShopIndex <= shopsToVisit.Count - 1)
                        {
                            string temp = shopsToVisit[fisrtShopIndex];

                            shopsToVisit[fisrtShopIndex] = shopsToVisit[secondShopIndex];
                            shopsToVisit[secondShopIndex] = temp;
                        }
                        break;

                    case "Place":
                        string tempShop = input[1];
                        int index = int.Parse(input[2]);

                        if (index >= -1 && index <= shopsToVisit.Count - 1)
                        {
                            shopsToVisit.Insert(index + 1, tempShop);
                        }
                        break;
                }
            }
            Console.WriteLine("Shops left:");

            foreach (var shop in shopsToVisit)
            {
                Console.Write(string.Join(" ", shop + " "));
            }
        }
    }
}
