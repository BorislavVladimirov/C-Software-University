using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Models
{
    public class Hotel : IHotel
    {
        private int capacity = 10;
        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
            this.Capacity = capacity;
        }

        public int Capacity { get; }

        public IReadOnlyDictionary<string, IAnimal> Animals
            => this.animals;

        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Count == 10)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (this.animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            IAnimal animal = this.animals.First(a => a.Key == animalName).Value;

            animal.Owner = owner;
            animal.IsAdopt = true;

            this.animals.Remove(animalName);
        }
    }
}
