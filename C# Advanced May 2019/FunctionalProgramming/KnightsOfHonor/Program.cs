using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string> format = x => $"Sir {x}";

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(format)));

            print(names);
        }
    }
}
