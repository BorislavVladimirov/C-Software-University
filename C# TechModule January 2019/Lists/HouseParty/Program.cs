using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> outPutList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[2] == "not")
                {
                    if (outPutList.Contains(command[0]) == false)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    outPutList.Remove(command[0]);
                }
                else
                {
                    if (outPutList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        continue;
                    }
                    outPutList.Add(command[0]);
                }

            }
            foreach (var item in outPutList)
            {
                Console.Write(item);
                Console.WriteLine();
            }
        }
    }
}
