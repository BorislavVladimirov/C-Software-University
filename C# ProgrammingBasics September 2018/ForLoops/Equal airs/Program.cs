using System;

namespace Equal_airs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int lastSum = 0;
            int maxDiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                currentSum = firstNum + secondNum;

                maxDiff = currentSum - lastSum;
                
                lastSum = currentSum;
                if (i == 0)
                {
                    maxDiff = 0;
                }
            }
            if (maxDiff == 0)
            {
                
                Console.WriteLine($"Yes, value={currentSum}");

            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(maxDiff)}");
            }
        }
    }
}
