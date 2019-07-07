using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
