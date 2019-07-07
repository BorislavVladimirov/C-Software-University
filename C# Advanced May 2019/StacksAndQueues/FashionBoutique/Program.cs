using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capasityOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(input);
            int rackCount = 1;
            int sum = 0;

            while (clothes.Any())
            {
                if (clothes.Peek() + sum <= capasityOfRack)
                {
                    sum += clothes.Pop();

                    if (sum == capasityOfRack)
                    {
                        if (clothes.Any())
                        {
                            rackCount++;
                            sum = 0;
                        }
                    }
                }
                else
                {
                    rackCount++;
                    sum = 0;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
