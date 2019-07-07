using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;

        public Restaurant(string name)
        {
            this.Name = name;
            this.Salads = new List<Salad>();
        }
        public List<Salad> Salads { get; set; }
        public string Name { get; set; }

        public void Add(Salad salad)
        {
            this.Salads.Add(salad);
        }
        public bool Buy(string name)
        {
            if (this.Salads.Any(x => x.Name == name))
            {
                this.Salads.Remove(Salads.FirstOrDefault(x => x.Name == name));
                return true;
            }

            return false;
        }
        public Salad GetHealthiestSalad()
        {
            int minCalories = int.MaxValue;

            foreach (var salad in this.Salads)
            {
                if (salad.GetTotalCalories() < minCalories)
                {
                    minCalories = salad.Products.Sum(x => x.Calories);
                }
            }
            return this.Salads.FirstOrDefault(x => x.GetTotalCalories() == minCalories);
        }
        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} have {this.Salads.Count} salads:");

            foreach (var salad in this.Salads)
            {
                sb.AppendLine($"{salad.Name}");
            }

            return sb.ToString();
        }
    }
}
