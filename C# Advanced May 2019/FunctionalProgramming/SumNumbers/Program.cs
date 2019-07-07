﻿using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());

        }
    }
}
