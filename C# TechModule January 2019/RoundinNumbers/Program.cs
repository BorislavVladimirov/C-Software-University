using System;
using System.Linq;

namespace RoundinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double originalNumber = nums[i];
                int roundedNumber = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{originalNumber} => {roundedNumber}");
            }
            
        }
    }
}
