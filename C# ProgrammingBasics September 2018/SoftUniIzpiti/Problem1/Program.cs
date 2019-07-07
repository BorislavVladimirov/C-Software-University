using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForRest = int.Parse(Console.ReadLine());
            double pricePerHardware = double.Parse(Console.ReadLine());
            double pricePerSoftware = double.Parse(Console.ReadLine());
            double priceForFrappe = double.Parse(Console.ReadLine());

            double totalMoneySpent = priceForFrappe + 3 * pricePerHardware + 2 * pricePerSoftware;
            double restTimeLeft = timeForRest - 5 - (3 * 2) - (2 * 2);

            Console.WriteLine($"{totalMoneySpent:f2}");
            Console.WriteLine(restTimeLeft);
        }
    }
}
