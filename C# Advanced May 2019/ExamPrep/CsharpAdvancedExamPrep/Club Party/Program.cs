using System;
using System.Collections.Generic;
using System.Linq;

namespace Club_Party
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int hallCapasiy = int.Parse(Console.ReadLine());

            List<int> people = new List<int>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(input.Reverse());
            Queue<string> pendingHalls = new Queue<string>();

            while (queue.Any())
            {
                string currentHall = string.Empty;

                if (pendingHalls.Any())
                {
                    currentHall = pendingHalls.Dequeue();
                }
                else
                {
                    currentHall = queue.Dequeue();
                }

                if (!int.TryParse(currentHall, out int x))
                {
                    int currentHallCapasity = hallCapasiy;

                    while (true)
                    {
                        if (!queue.Any())
                        {
                            return;
                        }

                        string nextElement = queue.Peek();


                        if (int.TryParse(nextElement, out int y))
                        {
                            if (currentHallCapasity - y < 0)
                            {
                                if (!pendingHalls.Any())
                                {
                                    queue.Dequeue();

                                }

                                currentHallCapasity = 0;

                            }
                            else
                            {
                                currentHallCapasity -= y;
                                people.Add(y);
                                queue.Dequeue();
                            }
                        }
                        else
                        {
                            pendingHalls.Enqueue(nextElement);
                            queue.Dequeue();
                        }

                        if (currentHallCapasity == 0)
                        {
                            Console.Write($"{currentHall} -> ");
                            Console.WriteLine(string.Join(", ", people));

                            people = new List<int>();
                            break;
                        }
                    }
                }
            }
        }
    }
}
