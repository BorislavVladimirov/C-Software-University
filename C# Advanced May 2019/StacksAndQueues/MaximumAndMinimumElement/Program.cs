using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (query.Length == 2)
                {
                    stack.Push(query[1]);
                }
                else
                {
                    switch (query[0])
                    {
                        case 2:
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                            break;
                        case 3:
                            if (stack.Any())
                            {
                                Console.WriteLine(stack.Max());
                            }
                            break;
                        case 4:
                            if (stack.Any())
                            {
                                Console.WriteLine(stack.Min());
                            }
                            break;

                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
