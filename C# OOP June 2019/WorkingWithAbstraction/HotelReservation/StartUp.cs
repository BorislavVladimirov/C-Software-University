using System;

namespace HotelReservation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            string season = input[2];

            string discountType = DiscountType.None.ToString();

            if (input.Length == 4)
            {
                 discountType = input[3];
            }

            decimal result = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType);

            Console.WriteLine($"{result:f2}");
        }
    }
}
