using System;
using System.Linq;
using System.Numerics;
namespace fromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    

            for (int i = 0; i < n; i++)
            {
                long sumOfDigits = 0;
                string numbers = Console.ReadLine();
                long[] nums = numbers.Split().Select(long.Parse).ToArray();

                long firstNumber = nums[0];
                long secondNumber =nums[1];

                string maxNumber = Math.Abs(Math.Max(firstNumber, secondNumber)).ToString();

                for (int j = 0; j < maxNumber.Length; j++)
                {
                    sumOfDigits += maxNumber[j] - '0';
                }
                Console.WriteLine(sumOfDigits);
            }
        }
    }
}
