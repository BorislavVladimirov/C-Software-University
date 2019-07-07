using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartment = 0;

            if (month == "May" || month == "October")
            {
                priceForStudio = 50 * nightsCount;
                priceForApartment = 65 * nightsCount;

                if (nightsCount > 7 && nightsCount <= 14)
                {
                    priceForStudio = priceForStudio * 0.95 ;
                }
                else if (nightsCount > 14)
                {
                    priceForStudio = priceForStudio * 0.70 ;
                    priceForApartment = priceForApartment * 0.90;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.20 * nightsCount;
                priceForApartment = 68.70 * nightsCount;

                if (nightsCount > 14)
                {
                    priceForStudio = priceForStudio * 0.80;
                    priceForApartment = priceForApartment * 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = 76 * nightsCount;
                priceForApartment = 77 * nightsCount;

                if (nightsCount > 14)
                {
                    priceForApartment = priceForApartment * 0.90;
                }
            }
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
        }
    
    }
}
