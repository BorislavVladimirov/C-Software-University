    using System;

    namespace FamilyHouse
    {
        class Program
        {
            static void Main(string[] args)
            {
                int months = int.Parse(Console.ReadLine());
                double totalElectricityBill = 0;
                double totalOtherBills = 0;

                double totalBillsCost = 0;

                double waterBill = 0;
                double internetBill = 0;
                double otherBills = 0;

                for (int i = 0; i < months; i++)
                {
                    double electricityBill = double.Parse(Console.ReadLine());

                    totalElectricityBill += electricityBill;

                    waterBill = 20;
                    internetBill = 15;
                    otherBills = (electricityBill + waterBill + internetBill) * 1.2;
                    totalOtherBills += otherBills;

                    totalBillsCost += (electricityBill + waterBill + internetBill + otherBills);
                }
                Console.WriteLine($"Electricity: {totalElectricityBill:f2} lv");
                Console.WriteLine($"Water: {(months*20):f2} lv");
                Console.WriteLine($"Internet: {(months * 15):f2} lv");
                Console.WriteLine($"Other: {totalOtherBills:f2} lv");
                Console.WriteLine($"Average: {(totalBillsCost / months):f2} lv");
            }
        }
    }
