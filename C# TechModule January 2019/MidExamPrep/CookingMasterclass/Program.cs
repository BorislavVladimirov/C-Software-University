using System;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            decimal totalEggPrice = eggPrice * 10 * studentsCount;
            decimal totalApronPrice = apronPrice * (Math.Ceiling(studentsCount * (decimal)1.2));
            decimal totalFlourPrice = flourPrice * studentsCount - Math.Floor((studentsCount / 5) * flourPrice);

            decimal totalCosts = totalEggPrice + totalApronPrice + totalFlourPrice;

            if (totalCosts <= budget)
            {
                Console.WriteLine($"Items purchased for {totalCosts:f2}$.");
            }
            else
            {
                decimal diff = totalCosts - budget;
                Console.WriteLine($"{diff:f2}$ more needed.");
            }
        }
    }
}
