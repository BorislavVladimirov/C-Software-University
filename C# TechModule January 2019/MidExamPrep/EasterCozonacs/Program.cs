using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal priceForFloorPerKg = decimal.Parse(Console.ReadLine());


            decimal packOfEggsPrice = priceForFloorPerKg * 0.75M;
            decimal litreMilkPrice = (priceForFloorPerKg * 1.25M) / 4;

            decimal totalCozonacPrice = packOfEggsPrice + litreMilkPrice + priceForFloorPerKg;

            int coloredEggsCount = 0;
            int cozonacsMade = 0;

            int count = 0;

            while (budget >= totalCozonacPrice)
            {
                count++;
                cozonacsMade++;
                coloredEggsCount+= 3;
                budget -= totalCozonacPrice;

                if (cozonacsMade % 3 == 0)
                {
                    coloredEggsCount -= (cozonacsMade - 2);
                }

            }

            Console.WriteLine($"You made {cozonacsMade} cozonacs! Now you have {coloredEggsCount} eggs and {budget:f2}BGN left.");
        }
    }
}
