using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> products;

        public Salad(string name)
        {
            this.Name = name;
            this.Products = new List<Vegetable>();
        }

        public string Name { get; set; }
        public List<Vegetable> Products { get; set; }

        public int GetTotalCalories()
        {
            return this.Products.Sum(x => x.Calories);
        }
        public int GetProductCount()
        {
            return this.Products.Count;
        }
        public void Add(Vegetable product)
        {
            this.Products.Add(product);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var vegetable in this.Products)
            {
                sb.AppendLine($"{vegetable}");
            }

            return sb.ToString();
        }
    }
}
