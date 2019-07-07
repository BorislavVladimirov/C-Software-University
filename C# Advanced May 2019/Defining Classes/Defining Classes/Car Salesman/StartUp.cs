using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            string temp = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] currentEngine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = currentEngine[0];
                int power = int.Parse(currentEngine[1]);
                int displacement = -1;
                string efficiency = "n/a";

                for (int y = 2; y < currentEngine.Length; y++)
                {
                    if (int.TryParse(currentEngine[y], out int x))
                    {
                        displacement = x;
                    }
                    else
                    {
                        efficiency = currentEngine[y];
                    }
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] currentCar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = currentCar[0];

                string engineModel = currentCar[1];
                var engine = engines.FirstOrDefault(x => x.Model == engineModel);

                int weight = -1;
                string color = "n/a";

                for (int y = 2; y < currentCar.Length; y++)
                {
                    if (int.TryParse(currentCar[y], out int x))
                    {
                        weight = x;
                    }
                    else
                    {
                        color = currentCar[y];
                    }
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
