using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();

                string inputData = input[0];
                int number = int.Parse(input[1]);

                switch (inputData)
                {
                    case "Add":
                        numbers.Add(number);
                        break;
                    case "Remove":
                        numbers.Remove(number);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(number);
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), number);
                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
