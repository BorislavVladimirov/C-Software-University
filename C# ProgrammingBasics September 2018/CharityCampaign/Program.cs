using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double cakesIncome = cakesCount * 45;
            double wafflesIncome = wafflesCount * 5.80;
            double pancakeIncome = pancakeCount * 3.20;
            double totalIncomePerDay = (cakesIncome + wafflesIncome + pancakeIncome) * bakersCount;
            double totalCampainIncome = totalIncomePerDay * days;
            double totalIncomeAfterExpences = totalCampainIncome - (0.125 * totalCampainIncome);

            Console.WriteLine($"{totalIncomeAfterExpences:f2}");

        }
    }
}
