using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int AgeOfLily = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int moneyFromToys = 0;
            int toysCount = 0;
            int moneySum = 0;
            int moneyLilyGets = 0;

            for (int i = 1; i <= AgeOfLily; i++)
            {               
                if (i % 2 == 0)
                {                    
                    moneyLilyGets += 10;
                    moneySum = moneySum + moneyLilyGets;
                    moneySum--;
                    
                }
                else if (i % 2 == 1)
                {
                    toysCount++;
                    moneyFromToys = toysCount * pricePerToy;
                }
            }
            double totalMoneySaved = moneyFromToys + moneySum;

            if (totalMoneySaved >= washingMachinePrice)
            {
                double diff = totalMoneySaved - washingMachinePrice;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else 
            {
                double diff = washingMachinePrice - totalMoneySaved;
                Console.WriteLine($"No! {diff:f2}");
            }
            
        }
    }
}
