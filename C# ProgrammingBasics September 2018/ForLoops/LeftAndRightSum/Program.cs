using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSUm = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                leftSum += a;
            }

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                rightSUm += b;
            }
            if (leftSum == rightSUm)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSUm);
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
