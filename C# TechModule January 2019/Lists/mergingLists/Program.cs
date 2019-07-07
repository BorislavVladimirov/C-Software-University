using System;
using System.Collections.Generic;
using System.Linq;

namespace mergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            while (firstNumbers.Count > 0 && secondNumbers.Count > 0)
            {
                resultList.Add(firstNumbers[0]);
                firstNumbers.RemoveAt(0);

                resultList.Add(secondNumbers[0]);
                secondNumbers.RemoveAt(0);

            }
            if (firstNumbers.Count > 0)
            {
                resultList.AddRange(firstNumbers);
            }
            else if (secondNumbers.Count > 0)
            {
                resultList.AddRange(secondNumbers);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
