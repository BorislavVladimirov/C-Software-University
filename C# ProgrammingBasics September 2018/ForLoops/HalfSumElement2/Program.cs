using System;

namespace HalfSumElement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum = int.MinValue;
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > biggestNum)
                {
                    biggestNum = num;
                }
            }
            if ((sum - biggestNum) == biggestNum)
            {
                Console.WriteLine($"Yes, Sum = {biggestNum}");
            }
            else
            {
                int diff = biggestNum - (sum - biggestNum);
                Console.WriteLine($"No, Diff = {Math.Abs(diff)}");
            }
        }
    }
}
