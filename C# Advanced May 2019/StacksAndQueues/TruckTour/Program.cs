using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<int[]> petrolFromPumps = new Queue<int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] pairs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                petrolFromPumps.Enqueue(pairs);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var petrolPump in petrolFromPumps)
                {
                    int petrolAmout = petrolPump[0];
                    int distance = petrolPump[1];

                    totalFuel += petrolAmout - distance;

                    if (totalFuel < 0)
                    {
                        petrolFromPumps.Enqueue(petrolFromPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}