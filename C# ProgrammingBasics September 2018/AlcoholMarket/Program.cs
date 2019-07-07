using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice * 0.5;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double whiskeySum = whiskeyPrice * whiskeyQuantity;
            double beerSum = beerPrice * beerQuantity;
            double wineSum = winePrice * wineQuantity;
            double rakiaSum = rakiaPrice * rakiaQuantity;

            double totalSum = whiskeySum + beerSum + wineSum + rakiaSum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
