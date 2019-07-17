using System;
using System.Linq;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(carTokens[1]);
            double fuelConsumpion = double.Parse(carTokens[2]);
            double tankCapacity = double.Parse(carTokens[3]);

            Car car = new Car(fuelQuantity, fuelConsumpion, tankCapacity);

            string[] truckTokens = Console.ReadLine().Split();
            fuelQuantity = double.Parse(truckTokens[1]);
            fuelConsumpion = double.Parse(truckTokens[2]);
            tankCapacity = double.Parse(truckTokens[3]);

            Truck truck = new Truck(fuelQuantity, fuelConsumpion, tankCapacity);

            string[] busTokens = Console.ReadLine().Split();
            fuelQuantity = double.Parse(busTokens[1]);
            fuelConsumpion = double.Parse(busTokens[2]);
            tankCapacity = double.Parse(busTokens[3]);

            Bus bus = new Bus(fuelQuantity, fuelConsumpion, tankCapacity);


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string typeOfCommand = command[0];
                string typeOfVehilce = command[1];

                if (typeOfCommand == "Drive")
                {
                    double distance = double.Parse(command[2]);

                    if (typeOfVehilce == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (typeOfVehilce == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(bus.Drive(distance));
                    }
                }
                else if (typeOfCommand == "Refuel")
                {
                    try
                    {
                        double fuelAmount = double.Parse(command[2]);

                        if (typeOfVehilce == "Car")
                        {
                            car.Refuel(fuelAmount);
                        }
                        else if (typeOfVehilce == "Truck")
                        {
                            truck.Refuel(fuelAmount);
                        }
                        else
                        {
                            bus.Refuel(fuelAmount);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else
                {
                    double distance = double.Parse(command[2]);
                    Console.WriteLine(bus.DriveEmpty(distance));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
