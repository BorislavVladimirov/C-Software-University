using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();
            List<string> vehicleTypes = new List<string>() { "Car", "Truck" };

            while (input != "End")
            {
                string[] inputData = input.Split();

                string typeOfVehicle = inputData[0];
                string type = char.ToUpper(typeOfVehicle[0]) + typeOfVehicle.Substring(1).ToLower();
                
                string model = inputData[1];
                string colour = inputData[2];
                int hoursePower = int.Parse(inputData[3]);
                
                Vehicle vehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Colour = colour,
                    HorsePower = hoursePower,
                };

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }
            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Where(v => v.Model == command))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Colour}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
                command = Console.ReadLine();
            }


            foreach (var type in vehicleTypes)
            {
                int vehiclesCount = 0;
                double avgHp = 0;

                if (vehicles.Count(v => v.Type == type) == 0)
                {
                    Console.WriteLine($"{type}s have average horsepower of: {0:f2}.");
                }
                else
                {
                    foreach (var vehicle in vehicles.Where(v => v.Type == type))
                    {
                        avgHp += vehicle.HorsePower;
                        vehiclesCount++;
                    }
                    Console.WriteLine($"{type}s have average horsepower of: {(avgHp / vehiclesCount):f2}.");
                }
            }

        }
        class Vehicle
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Colour { get; set; }

            public int HorsePower { get; set; }
        }
    }
}
