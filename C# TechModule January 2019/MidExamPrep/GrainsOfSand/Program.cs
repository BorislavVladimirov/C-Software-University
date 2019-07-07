using System;
using System.Collections.Generic;
using System.Linq;

namespace GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> grains = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Mort")
            {
                string[] input = command.Split();

                string operation = input[0];

                int value = int.Parse(input[1]);

                switch (operation)
                {
                    case "Add":
                        grains.Add(value);
                        break;

                    case "Remove":

                        if (!grains.Contains(value))
                        {
                            if (value >= 0 && value < grains.Count)
                            {
                                grains.RemoveAt(value);
                            }
                        }
                        else
                        {
                            grains.Remove(value);
                        }
                        break;
                    case "Replace":
                        int secondValue = int.Parse(input[2]);

                        if (grains.Contains(value))
                        {
                            grains[grains.IndexOf(value)] = secondValue;
                        }
                        break;
                    case "Increase":

                        int temp = grains.FirstOrDefault(e => e >= value);

                        if (temp == 0)
                        {
                            //if (!grains.Contains(0))
                            //{

                            //}
                            temp = grains[grains.Count - 1];

                            for (int i = 0; i < grains.Count; i++)
                            {
                                grains[i] += temp;
                            }
                        }
                        else /*(grains.Contains(temp))*/
                        {
                            for (int i = 0; i < grains.Count; i++)
                            {
                                grains[i] += temp;
                            }
                        }
                        break;
                    case "Collapse":

                        grains.RemoveAll(e => e < value);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", grains));
        }
    }
}
