using System;
using System.Linq;

namespace printNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }
            for (int index = nums.Length - 1; index >= 0; index--)
            {
                Console.Write(nums[index] + " ");
            }

        }
    }
}
