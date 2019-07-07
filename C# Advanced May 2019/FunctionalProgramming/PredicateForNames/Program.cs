using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)  
                .ToList();

            Predicate<int> filter = x => x <= n;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(x => filter(x.Length))));
        }
    }
}
