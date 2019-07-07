using System;

namespace GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double moneyWon = int.Parse(Console.ReadLine());

            double totalGasMoney = (distance * (fuelConsumption / 100)) * fuelPrice;
            double moneyLeft = moneyWon - totalGasMoney;
            double moneyPerPerson = moneyWon / 5;

            if (moneyWon >= totalGasMoney)
            {
                Console.WriteLine($"You can go home. {moneyLeft:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {moneyPerPerson:f2} money.");
            }
        }
    }
}
