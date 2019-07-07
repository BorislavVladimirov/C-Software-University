using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapasity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();


            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Add":
                        train.Add(int.Parse(input[1]));
                        break;
                    default:
                        for (int i = 0; i < train.Count; i++)
                        {
                            if (int.Parse(input[0]) + train[i] > maxCapasity)
                            {
                                continue;
                            }
                            else
                            {
                                train[i] += int.Parse(input[0]);
                                break;
                            }
                        }
                        break;
                }
                input = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
