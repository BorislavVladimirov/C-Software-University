using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] specialNumAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int indexOfSpecialNum = numbers.IndexOf(specialNumAndPower[0]);

            DetonateNumbers(numbers, specialNumAndPower, indexOfSpecialNum);
            GetSum(numbers);
        }
        private static void GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        private static void DetonateNumbers(List<int> numbers, int[] specialNumAndPower, int indexOfSpecialNum)
        {
            while (numbers.Contains(specialNumAndPower[0]))
            {
                for (int i = 1; i <= specialNumAndPower[1]; i++)    
                {
                    if (indexOfSpecialNum - i < 0)
                    {
                        break;
                    }
                    numbers.RemoveAt(indexOfSpecialNum - i);
                }
                indexOfSpecialNum = numbers.IndexOf(specialNumAndPower[0]);

                for (int i = 1; i <= specialNumAndPower[1]; i++)
                {
                    if (indexOfSpecialNum + 1 > numbers.Count)
                    {
                        break;
                    }
                    numbers.RemoveAt(indexOfSpecialNum + 1);
                }
                numbers.RemoveAt(indexOfSpecialNum);
                indexOfSpecialNum = numbers.IndexOf(specialNumAndPower[0]); 
            }
        }
    }
}
