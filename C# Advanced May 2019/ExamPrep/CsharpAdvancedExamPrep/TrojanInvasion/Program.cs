using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            int[] inputPlates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> plates = new List<int>(inputPlates);
            List<int> warriors = new List<int>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                if (!plates.Any())
                {
                    break;
                }

                int[] inputWarriors = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 3 == 0)
                {
                    int plateToAdd = int.Parse(Console.ReadLine());

                    plates.Add(plateToAdd);
                }

                warriors = new List<int>(inputWarriors);

                while (warriors.Any())
                {
                    if (!plates.Any())
                    {
                        break;
                    }

                    int currentWarrior = warriors[warriors.Count - 1];
                    int currentPlate = plates[0];

                    if (currentWarrior > currentPlate)
                    {
                        plates.RemoveAt(0);
                        warriors[warriors.Count - 1] -= currentPlate;
                    }
                    else if (currentWarrior < currentPlate)
                    {
                        warriors.RemoveAt(warriors.Count - 1);
                        plates[0] -= currentWarrior;
                    }
                    else if (currentWarrior == currentPlate)
                    {
                        warriors.RemoveAt(warriors.Count - 1);
                        plates.RemoveAt(0);
                    }
                }

            }

            Print(warriors, plates);
        }

        private static void Print(List<int> warriors, List<int> plates)
        {
            if (!plates.Any())
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
            }
            else if (plates.Any())
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            }

            if (warriors.Any())
            {
                Console.Write("Warriors left: ");

                warriors.Reverse();

                Console.Write(string.Join(", ", warriors));

            }
            else if (plates.Any())
            {
                Console.Write("Plates left: ");

                Console.Write(string.Join(", ", plates));

            }
        }
    }
}
