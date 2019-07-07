using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] bound = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            int startNum = bound[0];
            int endNum = bound[1];

            Predicate<int> filter = x => command == "odd" ? x % 2 != 0 : x % 2 == 0;

            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(String.Join(" ",numbers.Where(x => filter(x))));
        }
    }
}
