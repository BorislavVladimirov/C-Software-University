using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    public class Program
    {
        public static object Hashset { get; private set; }

        static void Main(string[] args)
        {
            string command = string.Empty;
            HashSet<string> set = new HashSet<string>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tempInput = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeOfCommand = tempInput[0];
                string numberplate = tempInput[1];

                switch (typeOfCommand)
                {
                    case "IN":
                        set.Add(numberplate);
                        break;
                    case "OUT":
                        set.Remove(numberplate);
                        break;
                }
            }
            if (set.Count != 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
