using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            double moneyLeft = 0;
            int moneySpendCount = 0;

            while (true)
            {
                string type = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                daysCount++;

                if (type == "spend")
                {
                    moneyLeft = availableMoney - sum;
                    availableMoney = moneyLeft;
                    moneySpendCount++;

                    if (sum > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    if (moneySpendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        return;
                    }
                }
                else if (type == "save")
                {
                    if (moneySpendCount != 0)
                    {
                        moneySpendCount = 0;
                        
                    }
                    
                    moneyLeft = availableMoney + sum;
                    availableMoney = moneyLeft;
                }
                if (availableMoney >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {daysCount} days.");
                    return;
                }
            }
        }
    }
}
