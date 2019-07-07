using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightsum += numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                rightsum -= numbers[i];   

                if (rightsum == leftsum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftsum += numbers[i];
            }
            Console.WriteLine("no");
        }
    }
}
