using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            // h = 2.30;
            // approximately Paint Consumption -> ~170 grams per 1 square Meter (Manufacturer's value) 

            double totalCeilingSqM = 5.75 * 3.35 + 3.65 * 4.85 + 4.25 * 4.55 + 4.85 * 4.71 + 2.15 * 1.5 + 2.5 * 5.1;

            double kitchenWallsSqM = (4.85 * 2 + 4.71 * 2) * 2.30 ;
            double bedroomWallsSqM = (4.25 * 2 + 5.55 * 2) * 2.30;
            double livingrooomWallsSqM = (4.85 * 2 + 3.65 * 2) * 2.30;
            double gameZoneWallsSqM = (5.75 * 2 + 3.35 * 2) * 2.30;
            double closetWallsSqM = (5.12 * 2 + 2.50 * 2) * 2.30;
            double corridorWallsSqM = (1.50 * 2 + 2.5 * 2 ) * 2.30;

            double totalWallsSqM = kitchenWallsSqM + bedroomWallsSqM + livingrooomWallsSqM + gameZoneWallsSqM + closetWallsSqM + corridorWallsSqM;

            //approximately price per 5 kilograms of white paint ~ 15.90 BGN
            //approximately price per 5 kilograms of coloured paint ~ 14.00 BGN

            double approximatelyPricePеrFiveKgWhitePaint = 15.90;
            double approximatelyPricePеrFiveKgColourPaint = 14.00;

            // one bucket of paint (5 kgs ) should cover approximately 30 square meterers (Manufacturer's value)
            double totalExpensesWhitePaint = totalCeilingSqM / 30 * approximatelyPricePеrFiveKgWhitePaint;
            double totalColourPaint = totalWallsSqM / 30 * approximatelyPricePеrFiveKgColourPaint;

            // в сайта на боро пише 170 грама за пълно покриване, което го приемам че означава 2 ръце покритие. Ако не - всичко е Х 2 

            Console.WriteLine($"Total ceilings square meters: {totalCeilingSqM}");
            Console.WriteLine($"Total expenses for white paint: {totalExpensesWhitePaint:f2} BGN");
            Console.WriteLine("...........");
            Console.WriteLine($"Total walls square meters: {totalWallsSqM}");
            Console.WriteLine($"Total expenses for colour paint: {totalColourPaint:f2} BNG");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Overall paint expenses: {(totalExpensesWhitePaint + totalColourPaint):f2} BGN");
        }
    }
}
