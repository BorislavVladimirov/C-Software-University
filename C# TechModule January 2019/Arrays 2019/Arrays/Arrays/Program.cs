using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 101, 50, 18, 42, 99, 7, 7 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            double average = (double)sum / numbers.Length;
            Console.WriteLine(average);
        }
    }
}
