using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class Engine
    {
        private AnimalCentre animalCentre;
        private int procedureTime;
        private string name;
        private int energy;
        private int happiness;

        public Engine()
        {
            this.animalCentre = new AnimalCentre();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] arr = command.Split();

                string typeOfCommand = arr[0];

                try
                {
                    switch (typeOfCommand)
                    {
                        case "RegisterAnimal":
                            string type = arr[1];
                            this.name = arr[2];
                            this.energy = int.Parse(arr[3]);
                            this.happiness = int.Parse(arr[4]);
                            this.procedureTime = int.Parse(arr[5]);

                            Console.WriteLine(this.animalCentre.RegisterAnimal(type, this.name, this.energy, this.happiness, this.procedureTime));
                            break;
                        case "Chip":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[2]);

                            Console.WriteLine(this.animalCentre.Chip(this.name, this.procedureTime));
                            break;
                        case "Vaccinate":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[2]);

                            Console.WriteLine(this.animalCentre.Vaccinate(this.name, this.procedureTime));
                            break;
                        case "Fitness":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[2]);

                            Console.WriteLine(this.animalCentre.Fitness(this.name, this.procedureTime));
                            break;
                        case "Play":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[1]);

                            Console.WriteLine(this.animalCentre.Play(this.name, this.procedureTime));
                            break;
                        case "DentalCare":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[1]);

                            Console.WriteLine(this.animalCentre.DentalCare(this.name, this.procedureTime));
                            break;
                        case "NailTrim":
                            this.name = arr[1];
                            this.procedureTime = int.Parse(arr[1]);

                            Console.WriteLine(this.animalCentre.NailTrim(this.name, this.procedureTime));
                            break;
                        case "Adopt":
                            this.name = arr[1];
                            string owner = arr[2];

                            Console.WriteLine(this.animalCentre.Adopt(this.name, owner));
                            break;
                        case "History":
                            string procedureType = arr[1];

                            Console.WriteLine(this.animalCentre.History(procedureType));
                            break;
                    }

                }
                catch (Exception ex)
                {
                    if (ex.GetType().Name == "InvalidOperationException")
                    {
                        Console.WriteLine($"InvalidOperationException: { ex.Message}");
                    }
                    else
                    {
                        Console.WriteLine($"ArgumentException: { ex.Message}");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var animal in this.animalCentre.Animals.Where(a => a.IsAdopt == true).OrderBy(a => a.Owner))
            {
                Console.WriteLine($"--Owner: {animal.Owner}");
                Console.WriteLine($"    -Adopted animals: {animal.Name}");
            }
        }
    }
}
