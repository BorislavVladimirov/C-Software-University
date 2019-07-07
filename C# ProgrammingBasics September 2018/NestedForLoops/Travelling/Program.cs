using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            while (true)
            {
                string input = Console.ReadLine();
                double totalMoneySaved = 0;

                if (input == "End")
                {
                    return;
                }
                double minBudget = double.Parse(Console.ReadLine());
                
                while (true)
                {
                    double moneySaved = double.Parse(Console.ReadLine());
                    totalMoneySaved = totalMoneySaved + moneySaved;

                    if (totalMoneySaved >= minBudget)
                    {                        
                        Console.WriteLine($"Going to {input}!");
                        break;
                    }
                }

            }
        }
    }
}
