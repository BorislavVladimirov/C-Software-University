using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            double totalSum = 0;

            while (count < num)
            {               
                count++;
                double deposit = double.Parse(Console.ReadLine());     
                

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum = totalSum + deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
