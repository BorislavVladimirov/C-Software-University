using System;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double singerBudget = double.Parse(Console.ReadLine());

            double totalIncome = 0;
            double totalPeople = 0;
            string input = Console.ReadLine();

            while (input != "The restaurant is full")
            {
                int peopleCount = int.Parse(input);

                totalPeople += peopleCount;

                if (peopleCount < 5)
                {
                    totalIncome += (peopleCount * 100);
                }
                else if (peopleCount >= 5)
                {
                    totalIncome += (peopleCount * 70);
                }
                input = Console.ReadLine();
            }
            if (totalIncome >= singerBudget)
            {
                double moneyLeft = totalIncome - singerBudget;
                Console.WriteLine($"You have {totalPeople} guests and {moneyLeft} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalPeople} guests and {totalIncome} leva income, but no singer.");
            }
        }
    }
}
