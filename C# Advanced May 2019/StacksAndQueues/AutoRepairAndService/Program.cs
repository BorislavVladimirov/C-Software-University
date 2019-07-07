using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            Queue<string> awaitingVehicles = new Queue<string>(cars);
            Stack<string> servedVehicles = new Stack<string>();

            while (command != "End")
            {
                string[] input = command.Split(new[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries);

                switch (input[0])
                {
                    case "Service":
                        if (awaitingVehicles.Any())
                        {
                            string currentVehicle = awaitingVehicles.Peek();
                            servedVehicles.Push(currentVehicle);
                            Console.WriteLine($"Vehicle {awaitingVehicles.Dequeue()} got served.");
                        }                        
                        break;
                    case "History":
                        Console.WriteLine(string.Join(", ", servedVehicles));
                        break;
                    case "CarInfo":
                        string model = input[1];

                        if (awaitingVehicles.Contains(model))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            if (awaitingVehicles.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", awaitingVehicles)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");

        }
    }
}
