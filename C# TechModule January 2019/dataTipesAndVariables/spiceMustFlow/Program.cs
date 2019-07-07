using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int beggingYield = startingYield;
            int daysOperated = 0;
            int totalAmountExtracted = 0;
            int amountWorkersConsumed = 0;
            
            while (startingYield >= 100)
            {
                amountWorkersConsumed = 26;
                totalAmountExtracted += (startingYield - amountWorkersConsumed);
                daysOperated++;
                startingYield -= 10;
            }
            if (beggingYield >= 100)
            {
                totalAmountExtracted -= 26;
            }
            Console.WriteLine($"{daysOperated}");
            Console.WriteLine($"{totalAmountExtracted}");
        }
    }
}
