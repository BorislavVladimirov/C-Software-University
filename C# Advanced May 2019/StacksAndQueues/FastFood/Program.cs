using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Any())
            {
                if (foodQuantity <= 0)
                {
                    break;
                }
                int temp = queue.Peek();

                if (foodQuantity - temp >= 0)
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Any())
            {
                Console.Write($"Orders left: ");
                Console.Write(string.Join(" ", queue));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
