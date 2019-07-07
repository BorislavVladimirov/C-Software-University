using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tempArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = tempArr[0];
                double fuelAmaout = double.Parse(tempArr[1]);
                double fuelConsumptionPerKilometer = double.Parse(tempArr[2]);
                double travelledDistance = 0;

                Car car = new Car(model, fuelAmaout, fuelConsumptionPerKilometer, travelledDistance);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] inputArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = inputArr[1];
                double amautOfKm = double.Parse(inputArr[2]);

                Car car = cars.FirstOrDefault(x => x.Model == carModel);

                car.Drive(amautOfKm);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
