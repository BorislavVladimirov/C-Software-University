using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            InputProcessing(clothes, n);

            string[] searchedItems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string serachedColour = searchedItems[0];
            string searchedItem = searchedItems[1];

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var kvp in item.Value)
                {
                    if (item.Key == serachedColour && kvp.Key == searchedItem)
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }

        public static void InputProcessing(Dictionary<string, Dictionary<string, int>> clothes, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tempCommand = input
                         .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();

                string colour = tempCommand[0];

                string[] tempItems = tempCommand[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!clothes.ContainsKey(colour))
                {
                    clothes.Add(colour, new Dictionary<string, int>());

                    foreach (var clothe in tempItems)
                    {
                        if (!clothes[colour].ContainsKey(clothe))
                        {
                            clothes[colour].Add(clothe, 0);
                        }
                        clothes[colour][clothe]++;
                    }
                }
                else
                {
                    foreach (var clothe in tempItems)
                    {
                        if (!clothes[colour].ContainsKey(clothe))
                        {
                            clothes[colour].Add(clothe, 0);
                        }
                        clothes[colour][clothe]++;
                    }

                }
            }
        }
    }
}
