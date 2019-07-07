using System;

namespace HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal GetTotalPrice(decimal pricePerDay, int numberOfDays, string season, string discountType)
        {
            int currentSeason = 0;
            int discount = 0;

            if (Enum.TryParse(season, out Season x))
            {
                currentSeason = (int)x;
            }

            if (Enum.TryParse(discountType, out DiscountType y))
            {
                discount = (int)y;
            }

            decimal result = ((pricePerDay * numberOfDays) * currentSeason) * (1.0m - (discount / 100.0m));

            return result;
        }
    }
}
