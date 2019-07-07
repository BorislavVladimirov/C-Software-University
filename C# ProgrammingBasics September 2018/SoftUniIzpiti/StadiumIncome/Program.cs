using System;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            double sectorsCount = double.Parse(Console.ReadLine());
            double stadiumCapasity = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double gameIncome = 0;
            double moneyForCharity = 0;
            double incomePerSector = 0;


            double totalIncome = stadiumCapasity * ticketPrice;
            
            incomePerSector = totalIncome / sectorsCount;
            moneyForCharity = 0.125 * (totalIncome - (incomePerSector * 0.75));

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
