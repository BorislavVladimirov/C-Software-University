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

            List<Car> cars = new List<Car>();           

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tireSet = new Tire[4];
                int index = 0;

                for (int j = 5; j < input.Length; j += 2)
                {
                    double pressure = double.Parse(input[j]);
                    int age = int.Parse(input[j + 1]);

                    Tire tire = new Tire(age, pressure);

                    tireSet[index++] = tire;
                }

                Car car = new Car(model, engine, cargo, tireSet);
                cars.Add(car);

            }

            string line = Console.ReadLine();

            if (line == "fragile")
            {
                foreach (var car in cars.Where(x => x.Tires.Any(y => y.TirePressure < 1)))
                {
                    if (car.Cargo.CargoType == "fragile")
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (line == "flamable")
            {
                foreach (var car in cars.Where(x=> x.Engine.EnginePower > 250))
                {
                    if (car.Cargo.CargoType == "flamable")
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
