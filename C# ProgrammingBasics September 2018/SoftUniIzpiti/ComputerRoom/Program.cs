using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (type == "day")
                {
                    price = 10.50;
                }
                else if (type == "night")
                {
                    price = 8.40;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (type == "day")
                {
                    price = 12.60;
                }
                else if (type == "night")
                {
                    price = 10.20;
                }
            }
            if (peopleCount >= 4)
            {
                price = price * 0.9;
            }
            if (hoursSpent >= 5)
            {
                price = price * 0.5;
            }
            double totalCost = price * peopleCount * hoursSpent;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:f2}");
        }
    }
}
