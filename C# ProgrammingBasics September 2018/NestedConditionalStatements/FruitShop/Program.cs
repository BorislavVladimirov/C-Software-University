using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitType = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (fruitType == "banana" )
                {
                    price = 2.50 * quantity;
                }
                else if (fruitType == "apple")
                {
                    price = 1.20 * quantity;
                }
                else if (fruitType == "orange")
                {
                    price = 0.85 * quantity;
                }
                else if (fruitType == "grapefruit")
                {
                    price = 1.45 * quantity;
                }
                else if (fruitType == "kiwi")
                {
                    price = 2.70 * quantity;
                }
                else if (fruitType == "pineapple")
                {
                    price = 5.50 * quantity;
                }
                else if (fruitType == "grapes")
                {
                    price = 3.85 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (fruitType == "banana")
                {
                    price = 2.70 * quantity;
                }
                else if (fruitType == "apple")
                {
                    price = 1.25 * quantity;
                }
                else if (fruitType == "orange")
                {
                    price = 0.90 * quantity;
                }
                else if (fruitType == "grapefruit")
                {
                    price = 1.60 * quantity;
                }
                else if (fruitType == "kiwi")
                {
                    price = 3.00 * quantity;
                }
                else if (fruitType == "pineapple")
                {
                    price = 5.60 * quantity;
                }
                else if (fruitType == "grapes")
                {
                    price = 4.20 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
