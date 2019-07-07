using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputL = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] inputI = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(inputL);
            Stack<int> items = new Stack<int>(inputI);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            int glass = 25;
            int aluminium = 50;
            int lithium = 75;
            int carbonFiber = 100;

            int counterGlass = 0;
            int counterAluminium = 0;
            int counterLithium = 0;
            int counterCarbonFiber = 0;

            while (true)
            {
                if (liquids.Count <= 0)
                {
                    break;
                }

                if (items.Count <= 0)
                {
                    break;
                }

                int currentLiquid = liquids.Peek();
                int currentItem = items.Peek();

                if (currentLiquid + currentItem == glass)
                {
                    if (!dic.ContainsKey("Glass"))
                    {
                        counterGlass = 1;
                        dic.Add("Glass", counterGlass);
                    }
                    else
                    {
                        counterGlass++;
                        dic["Glass"] = counterGlass;

                    }
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == carbonFiber)
                {
                    if (!dic.ContainsKey("Carbon fiber"))
                    {
                        counterCarbonFiber = 1;
                        dic.Add("Carbon fiber", counterCarbonFiber);
                    }
                    else
                    {
                        counterCarbonFiber++;
                        dic["Carbon fiber"] = counterCarbonFiber;
                    }
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == lithium)
                {
                    if (!dic.ContainsKey("Lithium"))
                    {
                        counterLithium = 1;
                        dic.Add("Lithium", counterLithium);
                    }
                    else
                    {
                        counterLithium++;
                        dic["Lithium"] = counterLithium;
                    }
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == aluminium)
                {
                    if (!dic.ContainsKey("Aluminium"))
                    {
                        counterAluminium = 1;
                        dic.Add("Aluminium", counterAluminium);
                    }
                    else
                    {
                        counterAluminium++;
                        dic["Aluminium"] = counterAluminium;
                    }
                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    items.Pop();
                    items.Push(currentItem += 3);
                }

            }

            if (dic.ContainsKey("Glass") && dic.ContainsKey("Aluminium") &&
                dic.ContainsKey("Lithium") && dic.ContainsKey("Carbon fiber"))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine("Liquids left: " + string.Join(", ", liquids));

            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine("Physical items left: " + string.Join(", ", items));

            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            for (int i = 0; i < 4; i++)
            {
                if (!dic.ContainsKey("Glass"))
                {
                    dic.Add("Glass", 0);
                }
                if (!dic.ContainsKey("Aluminium"))
                {
                    dic.Add("Aluminium", 0);
                }
                if (!dic.ContainsKey("Lithium"))
                {
                    dic.Add("Lithium", 0);
                }
                if (!dic.ContainsKey("Carbon fiber"))
                {
                    dic.Add("Carbon fiber", 0);
                }
            }

            foreach (var item in dic.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}