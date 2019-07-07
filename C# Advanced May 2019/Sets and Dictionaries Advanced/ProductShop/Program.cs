using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] tempInput = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);

                string currentShop = tempInput[0];
                string product = tempInput[1];
                double price = double.Parse(tempInput[2]);

                if (!shops.ContainsKey(currentShop))
                {
                    shops.Add(currentShop, new Dictionary<string, double>());

                    if (!shops[currentShop].ContainsKey(product))
                    {
                        shops[currentShop].Add(product, price);
                    }
                }
                else
                {
                    if (!shops[currentShop].ContainsKey(product))
                    {
                        shops[currentShop].Add(product, price);
                    }

                }
                command = Console.ReadLine();
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
