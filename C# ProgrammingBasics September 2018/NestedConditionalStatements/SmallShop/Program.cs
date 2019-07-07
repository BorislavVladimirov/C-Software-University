using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (product == "coffee")
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.50 * quantity;
                        break;
                    case "Plovdiv":
                        price = 0.40 * quantity;
                        break;
                    case "Varna":
                        price = 0.45 * quantity;
                        break;
                }
            }
            else if (product == "water")
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.80 * quantity;
                        break;
                    case "Plovdiv":
                        price = 0.70 * quantity;
                        break;
                    case "Varna":
                        price = 0.70 * quantity;
                        break;
                }
            }
            else if (product == "beer")
            {
                switch (city)
                {
                    case "Sofia":
                        price = 1.2 * quantity;
                        break;
                    case "Plovdiv":
                        price = 1.15 * quantity;
                        break;
                    case "Varna":
                        price = 1.10 * quantity;
                        break;
                }
            }
            else if (product == "sweets")
            {
                switch (city)
                {
                    case "Sofia":
                        price = 1.45 * quantity;
                        break;
                    case "Plovdiv":
                        price = 1.30 * quantity;
                        break;
                    case "Varna":
                        price = 1.35 * quantity;
                        break;
                }
            }
            else if (product == "peanuts")
            {
                switch (city)
                {
                    case "Sofia":
                        price = 1.60 * quantity;
                        break;
                    case "Plovdiv":
                        price = 1.50 * quantity;
                        break;
                    case "Varna":
                        price = 1.55 * quantity;
                        break;
                }
            }
            Console.WriteLine(price);
        }
    }
}
