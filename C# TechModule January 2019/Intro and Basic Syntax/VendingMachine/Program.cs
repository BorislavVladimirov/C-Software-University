using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double currentSum = 0;
            string product = string.Empty.ToLower();
            double productPrice = 0;

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                currentSum += coins;
                input = Console.ReadLine();
            }

            if (input == "Start")
            {
                while (true)
                {
                    product = Console.ReadLine();

                    if (product == "End")
                    {
                        Console.WriteLine($"Change: {currentSum:f2}");
                        break;
                    }
                    switch (product)
                    {
                        case "Nuts":
                            currentSum -= 2;
                            productPrice = 2;
                            break;
                        case "Water":
                            currentSum -= 0.7;
                            productPrice = 0.7;
                            break;
                        case "Crisps":
                            currentSum -= 1.5;
                            productPrice = 1.5;
                            break;
                        case "Soda":
                            currentSum -= 0.8;
                            productPrice = 0.8;
                            break;
                        case "Coke":
                            currentSum -= 1;
                            productPrice = 1;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                    if (currentSum < productPrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }

            }
            
        }
    }
}
