using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<Car> cars = new Queue<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();

                for (int y = 5; y < input.Length; y += 2)
                {
                    double tirePressure = double.Parse(input[y]);
                    int tireAge = int.Parse(input[y + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires.ToArray());
                cars.Enqueue(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                while (cars.Count != 0)
                {
                    var current = cars.Dequeue();

                    if (current.Cargo.CargoType == "fragile" && current.Tires.Any(x => x.TirePressure < 1))
                    {
                        Console.WriteLine($"{current.Model}");
                    }
                }
            }

            else if (command == "flamable")
            {
                while (cars.Count != 0)
                {
                    var current = cars.Dequeue();

                    if (current.Cargo.CargoType == "flamable" && current.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(current.Model);
                    }
                }
            }
        }
    }
}
