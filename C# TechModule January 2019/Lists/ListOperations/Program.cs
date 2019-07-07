using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] operation = Console.ReadLine()
                .Split()
                .ToArray();

            while (operation[0] != "End")
            {
                switch (operation[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(operation[1]));
                        break;
                    case "Insert":
                        if (int.Parse(operation[2]) < 0 || int.Parse(operation[2]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(int.Parse(operation[2]), int.Parse(operation[1]));
                        break;
                    case "Remove":
                        if (int.Parse(operation[1]) < 0 || int.Parse(operation[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(int.Parse(operation[1]));
                        break;
                    case "Shift":
                        ShiftList(numbers, operation);
                        break;
                }
                operation = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftList(List<int> numbers, string[] operation)
        {
            if (operation[1] == "left")
            {
                for (int i = 0; i < int.Parse(operation[2]); i++)
                {
                    int tempNumber = numbers[0];
                    numbers.Add(tempNumber);
                    numbers.RemoveAt(0);
                }
            }
            else if (operation[1] == "right")
            {
                for (int i = 0; i < int.Parse(operation[2]); i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}
