using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableCount = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWight = double.Parse(Console.ReadLine());

            double coverArea = tableCount * ((tableLenght + 2 * 0.30) * (tableWight + 2 * 0.30));
            double checkArea = tableCount * ((tableLenght * 0.5) * (tableLenght * 0.5));

            double priceUSD = coverArea * 7 + checkArea * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");
        }
    }
}
