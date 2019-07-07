using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string command = Console.ReadLine();

            //Tires
            while (command != "No more tires")
            {
                Tire[] arr = new Tire[4];
                string[] commandArr = command.Split();
                int index = 0;

                for (int i = 0; i < commandArr.Length; i += 2)
                {
                    int year = int.Parse(commandArr[i]);
                    double pressure = double.Parse(commandArr[i + 1]);

                    Tire tire = new Tire(year, pressure);
                    arr[index++] = tire;
                }

                tires.Add(arr);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            //Engine
            while (command != "Engines done")
            {
                string[] arr = command.Split();

                int horsePower = int.Parse(arr[0]);
                double cubicCapacity = double.Parse(arr[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                command = Console.ReadLine();
            }


            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] arr = command.Split();

                string make = arr[0];
                string model = arr[1];
                int year = int.Parse(arr[2]);
                double fuelQuantity = double.Parse(arr[3]);
                double fuelConsumption = double.Parse(arr[4]);
                int engineIndex = int.Parse(arr[5]);
                int tiresIndex = int.Parse(arr[6]);

                Engine engine = engines[engineIndex];
                Tire[] tireSet = tires[tiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tireSet);
                cars.Add(car);
                
                command = Console.ReadLine();
            }

            foreach (var car in cars.Where(c => c.Year > 2016 
                        && c.Engine.HorsePower > 330 
                        && (c.Tires.Sum(tire => tire.Pressure) >= 9 && c.Tires.Sum(tire => tire.Pressure) <= 10)))
            {
                car.Drive(20);

                Console.WriteLine(car.WhoAmI());
            }
        }

        public class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            private Engine engine;
            private Tire[] tires;

            public string Make
            {
                get
                {
                    return this.make;
                }

                set
                {
                    this.make = value;
                }
            }

            public string Model
            {
                get
                {
                    return this.model;
                }

                set
                {
                    this.model = value;
                }
            }

            public int Year
            {
                get
                {
                    return this.year;
                }

                set
                {
                    this.year = value;
                }
            }

            public double FuelQuantity
            {
                get
                {
                    return this.fuelQuantity;
                }

                set
                {
                    this.fuelQuantity = value;
                }
            }

            public double FuelConsumption
            {
                get
                {
                    return this.fuelConsumption;
                }

                set
                {
                    this.fuelConsumption = value;
                }
            }

            public Engine Engine
            {
                get
                {
                    return this.engine;
                }

                set
                {
                    this.engine = value;
                }
            }

            public Tire[] Tires
            {
                get
                {
                    return this.tires;
                }

                set
                {
                    this.tires = value;
                }
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
                this.FuelQuantity = fuelQuantity;
                this.fuelConsumption = fuelConsumption;
            }
            public Car(string make, string model, int year, double fuelQuantity,
                double fuelConsumption, Engine engine, Tire[] tires)
                : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Engine = engine;
                this.Tires = tires;
            }

            public void Drive(double distance)
            {
                double fuelWasted = this.FuelQuantity - ((distance / 100) * this.FuelConsumption);

                if (fuelWasted < 0)
                {
                    System.Console.WriteLine("Not enough fuel to perform this trip!");
                    return;
                }

                this.FuelQuantity = fuelWasted;
            }

            public string WhoAmI()
            {
                return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: { this.FuelQuantity}";
            }
        }

        public class Engine
        {
            private int horsePower;

            private double cubicCapacity;

            public int HorsePower
            {
                get
                {
                    return this.horsePower;
                }

                set
                {
                    this.horsePower = value;
                }
            }
            public double CubicCapacity
            {
                get
                {
                    return this.cubicCapacity;
                }

                set
                {
                    this.cubicCapacity = value;
                }
            }

            public Engine(int horsePower, double cubicCapacity)
            {
                this.HorsePower = horsePower;
                this.CubicCapacity = cubicCapacity;
            }
        }

        public class Tire
        {
            private int year;
            private double pressure;

            public int Year
            {
                get
                {
                    return this.year;
                }

                set
                {
                    this.year = value;
                }
            }

            public double Pressure
            {
                get
                {
                    return this.pressure;
                }

                set
                {
                    this.pressure = value;
                }
            }

            public Tire(int year, double pressure)
            {
                this.Year = year;
                this.Pressure = pressure;
            }
        }
    }
}
