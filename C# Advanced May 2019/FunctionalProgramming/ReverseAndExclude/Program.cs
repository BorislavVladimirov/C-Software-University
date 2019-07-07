using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % n == 0;
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", numbers));

            numbers.RemoveAll(filter);
            numbers.Reverse();
            print(numbers);

        }
    }
}
