using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            Console.Write(string.Join(" ", firstSet.Where(x => secondSet.Contains(x))));

        }
    }
}
