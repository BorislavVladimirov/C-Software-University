using System;
using System.Collections.Generic;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("#");
            int waterQuantity = int.Parse(Console.ReadLine());

            double totalEffort = 0;
            List<int> cells = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] tempArr = input[i].Split(" = ");

                string typeOfFire = tempArr[0];
                int waterNeeded = int.Parse(tempArr[1]);


                switch (typeOfFire)
                {
                    case "High":
                        if (waterNeeded < 81 || waterNeeded > 125)
                        {
                            continue;
                        }
                        else
                        {
                            if (waterQuantity >= waterNeeded)
                            {
                                waterQuantity -= waterNeeded;
                                cells.Add(waterNeeded);
                                totalEffort += waterNeeded * 0.25;
                            }
                        }
                        break;
                    case "Medium":
                        if (waterNeeded < 51 || waterNeeded > 80)
                        {
                            continue;
                        }
                        else
                        {
                            if (waterQuantity >= waterNeeded)
                            {
                                waterQuantity -= waterNeeded;
                                cells.Add(waterNeeded);
                                totalEffort += waterNeeded * 0.25;
                            }
                        }
                        break;
                    case "Low":
                        if (waterNeeded < 1 || waterNeeded > 50)
                        {
                            continue;
                        }
                        else
                        {
                            if (waterQuantity >= waterNeeded)
                            {
                                waterQuantity -= waterNeeded;
                                cells.Add(waterNeeded);
                                totalEffort += waterNeeded * 0.25;
                            }
                        }
                        break;
                }
            }
            int totalFire = 0;

            Console.WriteLine("Cells:");

            foreach (var item in cells)
            {
                totalFire += item;

                Console.WriteLine($" - {item}");
            }

            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
