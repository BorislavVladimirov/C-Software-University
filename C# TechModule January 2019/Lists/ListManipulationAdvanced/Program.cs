using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            bool isChangeMade = false;
            string command = Console.ReadLine();
            int number = 0;

            while (command != "end")
            {
                string[] input = command.Split();

                string inputData = input[0];

                number = int.Parse(input[1]);


                switch (inputData)
                {
                    
                    case "Add":
                        numbers.Add(number);
                        isChangeMade = true;
                        break;
                    case "Remove":
                        numbers.Remove(number);
                        isChangeMade = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(number);
                        isChangeMade = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), number);
                        isChangeMade = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        
                        break;
                    case "PrintEven":
                        foreach (var num in numbers.Where( n => n % 2 == 0))
                        {
                            Console.WriteLine(num + " ");
                        }
                        break;
                    case "PrintOdd":
                        foreach (var num in numbers.Where(n => n % 2 != 0))
                        {
                            Console.WriteLine(num + " ");
                        }
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":

                        string condition = command[1].ToString();
                        int index = numbers.IndexOf(number);

                        if (condition == "<")
                        {
                            for (int i = 0; i < index; i++)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                        else if (condition == ">")
                        {
                            for (int i = index + 1; i < numbers.Count; i++)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                        else if (condition == ">=")
                        {
                            for (int i = index; i < numbers.Count; i++)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                        else if (condition == "<=")
                        {
                            for (int i = 0; i <= index; i++)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                        break;

                }

                command = Console.ReadLine();
            }
            if (isChangeMade)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
