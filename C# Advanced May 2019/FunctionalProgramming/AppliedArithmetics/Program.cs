using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            Func<List<int>, List<int>> addFunc = x => x.Select(y => y += 1).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(y => y -= 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(y => y *= 2).ToList();
            Action<List<int>> print = x => Console.Write(string.Join(" ", x));


            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
