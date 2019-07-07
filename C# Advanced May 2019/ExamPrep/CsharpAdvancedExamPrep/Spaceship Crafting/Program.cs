using System;
using System.Collections.Generic;
using System.Linq;

namespace Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>();
            List<int> items = new List<int>();

            Dictionary<string, List<int>> advancedMaterials = new Dictionary<string, List<int>>();

            int[] chemicalLiquids = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] physicalItems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            advancedMaterials.Add("Glass", new List<int>());
            advancedMaterials["Glass"].Add(0);

            advancedMaterials.Add("Aluminium", new List<int>());
            advancedMaterials["Aluminium"].Add(0);

            advancedMaterials.Add("Lithium", new List<int>());
            advancedMaterials["Lithium"].Add(0);

            advancedMaterials.Add("Carbon fiber", new List<int>());
            advancedMaterials["Carbon fiber"].Add(0);

            liquids = new Queue<int>(chemicalLiquids);
            items = new List<int>(physicalItems);
            List<string> resultItem = new List<string>();

            while (liquids.Any() && items.Count > 0)
            {
                int currentLiquid = liquids.Peek();
                int currentItem = items[items.Count - 1];

                if (currentLiquid + currentItem == 25)
                {
                    string material = "Glass";

                    advancedMaterials[material].Add(1);

                    liquids.Dequeue();
                    items.RemoveAt(items.Count - 1);

                    resultItem.Add("Glass");
                }
                else if (currentLiquid + currentItem == 50)
                {
                    string material = "Aluminium";

                    advancedMaterials[material].Add(1);

                    liquids.Dequeue();
                    items.RemoveAt(items.Count - 1);

                    resultItem.Add("Aluminium");
                }
                else if (currentLiquid + currentItem == 75)
                {
                    string material = "Lithium";

                    advancedMaterials[material].Add(1);

                    liquids.Dequeue();
                    items.RemoveAt(items.Count - 1);

                    resultItem.Add("Lithium");
                }
                else if (currentLiquid + currentItem == 100)
                {
                    string material = "Carbon fiber";

                    advancedMaterials[material].Add(1);

                    liquids.Dequeue();
                    items.RemoveAt(items.Count - 1);

                    resultItem.Add("Carbon fiber");

                }
                else
                {
                    liquids.Dequeue();
                    items[items.Count - 1] += 3;
                }
            }

            if (resultItem.Contains("Glass")
                && resultItem.Contains("Aluminium")
                && resultItem.Contains("Lithium")
                && resultItem.Contains("Carbon fiber"))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (!liquids.Any())
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }

            if (!items.Any())
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.Write("Physical items left: ");
                items.Reverse();
                Console.WriteLine(string.Join(", ", items));
            }

            foreach (var kvp in advancedMaterials.OrderBy(x => x.Key))
            {
                if (kvp.Value.Count == 1)
                {
                    if (kvp.Value.FirstOrDefault() == 0)
                    {
                        Console.WriteLine($"{kvp.Key}: {0}");
                    }
                    else
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value.Count() - 1}");
                    }
                }
                else
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count() - 1}");
                }
            }
        }
    }
}
