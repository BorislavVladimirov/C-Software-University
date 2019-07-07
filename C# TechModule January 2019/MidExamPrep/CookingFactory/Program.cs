using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> HighestQualityBatch = Console.ReadLine()
                 .Split("#")
                 .Select(int.Parse)
                .ToList();
 
            string input = Console.ReadLine();
 
            while (input != "Bake It!")
            {
                List<int> currentBatch = input.Split("#").Select(int.Parse).ToList();
 
                if (HighestQualityBatch.Sum() < currentBatch.Sum())
                {
                    HighestQualityBatch = currentBatch;
                }
                if (HighestQualityBatch.Sum() == currentBatch.Sum() && HighestQualityBatch.Count > currentBatch.Count)
                {
                    HighestQualityBatch = currentBatch;
                }
 
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {HighestQualityBatch.Sum()}");
            Console.WriteLine(string.Join(" ",HighestQualityBatch));
        }
    }
}
