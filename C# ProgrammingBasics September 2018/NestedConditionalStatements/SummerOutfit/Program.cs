using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string Outfit = "";
            string Shoes = "";

            if (time == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (temperature > 18 &&  temperature <= 24)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (temperature >= 25)
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (temperature >= 25)
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
            }
            else if (time == "Evening")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (temperature >= 25)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
