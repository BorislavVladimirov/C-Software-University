using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOFLightsaber = double.Parse(Console.ReadLine());
            double priceOFRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double lightsabersCost = priceOFLightsaber * Math.Ceiling(studentsCount * 1.1);
            double robesCost = priceOFRobe * studentsCount;
            double beltsCost = (priceOfBelt * studentsCount) - ((Math.Abs(studentsCount / 6)) * priceOfBelt);

            double totalCosts = lightsabersCost + robesCost + beltsCost;

            if (amountOfMoney >= totalCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCosts:f2}lv.");
            }
            else
            {
                double diff = totalCosts - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
