using System;

namespace rrders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            CalculatingTotalPrice(product, quantity, price);
        }

        private static void CalculatingTotalPrice(string product, int quantity, double price)
        {
            switch (product)
            {
                case "coffee":
                    price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1;
                    break;
                case "coke":
                    price = quantity * 1.40;
                    break;
                case "snacks":
                    price = quantity * 2;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
