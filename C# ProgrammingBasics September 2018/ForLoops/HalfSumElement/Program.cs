using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int biggestNum = int.MinValue;
            

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum = sum + num;
                if (num > biggestNum)
                {
                    biggestNum = num;
                }
                        
            }
            int totalSum = sum - biggestNum;
            if (totalSum == biggestNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNum}");
            }
            else
            {
               
                int diff = biggestNum - totalSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }

        }
    }
}
