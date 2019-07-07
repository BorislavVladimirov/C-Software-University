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
                string[] inputData = input.Split(" ", StringSplitOptions.None);

                string typeOfVehicle = inputData[0];

                if (typeOfVehicle.Length > 1)
                {
                    typeOfVehicle = char.ToUpper(typeOfVehicle[0]) + typeOfVehicle.Substring(1);
                }

                string model = inputData[1];
                string colour = inputData[2];
                int hoursePower = int.Parse(inputData[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, colour, hoursePower);

                var parts = new List<string> { "engine", "driveshaft" };

                vehicle.AddParts(parts);

                Console.WriteLine(string.Join(" ", vehicle.Parts));

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == "Tesla")
                {
                    vehicles.Remove(vehicle);
                }
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


            foreach (var type in vehicleTypes.OrderBy(t => t))
            {
                int vehiclesCount = 0;
                double avgHp = 0;

                foreach (var vehicle in vehicles.Where(v => v.Type == type))
                {
                    avgHp += vehicle.HorsePower;
                    vehiclesCount++;
                }
                if (avgHp == 0)
                {
                    Console.WriteLine($"{type}s have average horsepower of: {0:f2}.");
                }
                else
                {
                    Console.WriteLine($"{type}s have average horsepower of: {(avgHp / vehiclesCount):f2}.");
                }
            }

        }
        class Vehicle
        {
            private string type;
            private readonly List<string> parts;

            public Vehicle(string type, string model, string colour, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Colour = colour;
                this.HorsePower = horsePower;
                this.parts = new List<string>();
            }

            public string Type
            {
                get
                {
                    return this.type;
                }
                private set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("BABA YAGA");
                    }

                    this.type = value;
                }
            }

            public string Model { get; set; }

            public string Colour { get; set; }

            public int HorsePower { get; set; }

            public IReadOnlyCollection<string> Parts
                => this.parts.AsReadOnly();



            public void AddParts(List<string> parts)
            {
                this.parts.AddRange(parts);
            }
        }
    }
}
