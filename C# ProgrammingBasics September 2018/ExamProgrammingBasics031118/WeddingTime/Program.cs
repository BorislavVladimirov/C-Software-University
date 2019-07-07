using System;

namespace WeddingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double champagneQuantity = double.Parse(Console.ReadLine());
            double whiskyQuantity = double.Parse(Console.ReadLine());

            double champagnePrice = whiskyPrice * 0.5;
            double winePrice = champagnePrice * 0.4;
            double waterPrice = champagnePrice * 0.1;

            double totalPrice = whiskyPrice * whiskyQuantity + champagnePrice * champagneQuantity + wineQuantity * winePrice + waterPrice * waterQuantity;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
