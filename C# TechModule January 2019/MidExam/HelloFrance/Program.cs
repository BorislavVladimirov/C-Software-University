using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            double budget = double.Parse(Console.ReadLine());

            double clothesMaxPrice = 50;
            double shoesMaxPrice = 35;
            double accessoriesMaxPrice = 20.50;

            double profit = 0;
            double sum = 0;

            for (int i = 0; i < items.Count; i++)
            {
                string[] currentItem = items[i].Split("->", StringSplitOptions.RemoveEmptyEntries);

                string type = currentItem[0];
                double price = double.Parse(currentItem[1]);

                string temp = string.Empty;

                switch (type)
                {
                    case "Clothes":
                        if (clothesMaxPrice >= price && budget >= price)
                        {
                            budget -= price;
                            profit += price * 0.4;
                            sum += price;
                            temp = $"{price *= 1.4:f2}";
                            result.Add(temp);
                        }
                        break;
                    case "Shoes":
                        if (shoesMaxPrice >= price && budget >= price)
                        {
                            budget -= price;
                            profit += price * 0.4;
                            sum += price;
                            temp = $"{price *= 1.4:f2}";
                            result.Add(temp);
                        }
                        break;
                    case "Accessories":
                        if (accessoriesMaxPrice >= price && budget >= price)
                        {
                            budget -= price;
                            profit += price * 0.4;
                            sum += price;
                            temp = $"{price *= 1.4:f2}";
                            result.Add(temp);
                        }
                        break;
                }
            }
            sum *= 1.4;
            budget += profit;
            budget += sum;

            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine($"Profit: {profit:f2}");

            if (budget >= 150)
            {
                Console.WriteLine($"Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
