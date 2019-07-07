using System;

namespace ElementEqualsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnumber = int.MinValue;
            int sum = 0;
            

            for (int i = 0; i < n; i++)
            {
               int num = int.Parse(Console.ReadLine());

                if (num > maxnumber)
                {
                    maxnumber = num;
                }
                sum += num;
            }

            sum = sum - maxnumber;
            int diff = sum - maxnumber;

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
