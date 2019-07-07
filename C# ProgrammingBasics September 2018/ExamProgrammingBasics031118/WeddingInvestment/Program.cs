using System;

namespace WeddingInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeOfContrackt = Console.ReadLine();
            string typeOfContrackt = Console.ReadLine();
            string desertWanter = Console.ReadLine();
            int monthsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeOfContrackt)
            {
                case "Small":
                    if (timeOfContrackt == "one")
                    {
                        price = 9.98;
                    }
                    else if (timeOfContrackt == "two")
                    {
                        price = 8.58;
                    }break;

                case "Middle":
                    if (timeOfContrackt == "one")
                    {
                        price = 18.99;
                    }
                    else if (timeOfContrackt == "two")
                    {
                        price = 17.09;
                    }
                    break;

                case "Large":
                    if (timeOfContrackt == "one")
                    {
                        price = 25.98;
                    }
                    else if (timeOfContrackt == "two")
                    {
                        price = 23.59;
                    }
                    break;

                case "ExtraLarge":
                    if (timeOfContrackt == "one")
                    {
                        price = 35.99;
                    }
                    else if (timeOfContrackt == "two")
                    {
                        price = 31.79;
                    }
                    break;
            }
            if (desertWanter == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <=30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }
            if (timeOfContrackt == "two")
            {
                price = price * 0.9625;
            }
            price *= monthsCount;

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
