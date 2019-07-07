using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            if (type == "Premiere")
            {
                totalIncome = r * c * 12;
            }
            else if (type == "Normal")
            {
                totalIncome = r * c * 7.50;
            }
            else if (type == "Discount")
            {
                totalIncome = r * c * 5;
            }
            Console.WriteLine($"{totalIncome:f2}");

            
        }
    }
}
