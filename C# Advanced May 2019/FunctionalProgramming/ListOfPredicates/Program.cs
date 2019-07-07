using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        public static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            var num = Enumerable.Range(0, upperBound).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();
            List<int> resultNums = new List<int>();


            foreach (var currentNumber in numbers)
            {
                predicates.Add(x => x % currentNumber == 0);
            }

            for (int i = 1; i <= upperBound; i++)
            {

                int count = 0;

                foreach (var predicate in predicates)
                {
                    if (predicate(i))
                    {
                        count++;
                    }
                }

                if (count == predicates.Count)
                {
                    resultNums.Add(i);
                }
            }

            Console.Write(string.Join(" ", resultNums));
        }
    }
}
