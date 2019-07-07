using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneySpent = 0;
            string type = "";
            string destination = "";

            if (budget <= 100 && budget > 0)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    type = "Camp";
                    moneySpent = budget * 0.3;
                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    type = "Hotel";
                    moneySpent = budget * 0.7;
                }
            }
            else if (budget > 100 & budget <= 1000)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    type = "Camp";
                    moneySpent = budget * 0.4;
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    type = "Hotel";
                    moneySpent = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                moneySpent = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpent:f2}");
        }
    }
}
