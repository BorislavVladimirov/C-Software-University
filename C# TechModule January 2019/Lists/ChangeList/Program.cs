using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Delete":
                        numbers.RemoveAll( x => x == (int.Parse(input[1])));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }
                 input = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
