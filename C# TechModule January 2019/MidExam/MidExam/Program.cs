using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double peopleCount = double.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());
            double roomPrice = double.Parse(Console.ReadLine());

            double totalFoodExpenses = daysCount * peopleCount * foodPerDay;
            double totalHotelEpenses = daysCount * peopleCount * roomPrice;
            double totalFuelExpenses = 0;

            if (peopleCount > 10)
            {
                totalHotelEpenses *= 0.75;
            }

            double currentExpenses = totalFoodExpenses + totalHotelEpenses;
            double reduced = 0;
            double additionalExp = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                double distance = double.Parse(Console.ReadLine());

                totalFuelExpenses += distance * fuelPerKilometer;

                

                if (i % 3 == 0 || i % 5 == 0)
                {
                    additionalExp += currentExpenses * 0.4 ;
                }
                if (i % 7 == 0)
                {
                    currentExpenses -= currentExpenses / peopleCount;
                }
                if (currentExpenses > budget)
                {
                    Console.WriteLine("Not enough money to continue the trip");
                }

                currentExpenses += totalFuelExpenses;
            }
            currentExpenses += additionalExp;
            currentExpenses -= reduced;

            budget -= currentExpenses;

            if (budget < 0)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {Math.Abs(budget):f2}$ more.");
            }
            else
            {
                Console.WriteLine($"You have reached the destination. You have {budget:f2}$ budget left.");
            }

            
        }
    }
}
