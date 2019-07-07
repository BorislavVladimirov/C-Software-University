using System;
using System.Collections.Generic;
using System.Linq;

namespace P03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (true)
            {
                string[] currentFarm = Console.ReadLine().Split();

                for (int i = 0; i < currentFarm.Length; i += 2)
                {
                    int ammount = int.Parse(currentFarm[i]);
                    string material = currentFarm[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += ammount;

                        if (materials[material] >= 250)
                        {
                            PrintResult(materials, junk, material);
                            return;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += ammount;
                        }
                        else
                        {
                            junk.Add(material, ammount);
                        }
                    }
                }
            }

        }

        private static void PrintResult(Dictionary<string, int> materials,
                                        Dictionary<string, int> junk, string material)
        {
            PrintTheObtainedItem(material);
            materials[material] -= 250;
            var materialsOutput = materials.OrderByDescending(x => x.Value)
                                           .ThenBy(x => x.Key);
            foreach (var currentMaterial in materialsOutput)
            {
                Console.WriteLine($"{currentMaterial.Key}: {currentMaterial.Value}");
            }
            var junkOutput = junk.OrderBy(x => x.Key);
            foreach (var currentMaterial in junkOutput)
            {
                Console.WriteLine($"{currentMaterial.Key}: {currentMaterial.Value}");
            }
        }

        private static void PrintTheObtainedItem(string material)
        {
            switch (material)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }
        }
    }
}