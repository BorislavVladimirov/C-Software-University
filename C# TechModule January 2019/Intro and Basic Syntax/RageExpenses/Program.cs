using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashedCount = 0;
            int mouseTrashedCount = 0;
            int keyboardTrashedCount = 0;
            int displayTrashedCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashedCount++;
                }
                if (i % 3 == 0)
                {
                    mouseTrashedCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardTrashedCount++;

                    if (keyboardTrashedCount % 2 == 0 && keyboardTrashedCount > 1)
                    {
                        displayTrashedCount++;
                    }
                }
                
            }
            double totalExpences =
                headsetTrashedCount * headsetPrice +
                mouseTrashedCount * mousePrice +
                keyboardTrashedCount * keyboardPrice +
                displayTrashedCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpences:f2} lv.");
        }
    }
}
