using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private double weight;
        private string flourType;
        private string bakingTechnique;
        private double calories;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.Weight = weight;
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
        }

        public double Weight { get; set; }

        public string FlourType { get; set; }

        public string BakingTechnique { get; set; }

        public double Calories => this.calories;

        public void GetTotalCalories()
        {
            if (this.flourType.ToLower() == "white")
            {
                this.calories = 2 * this.weight * 1.5;
            }
            else
            {
                this.calories = 2 * this.Weight * 1.0;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    this.calories *= 0.9;
                    break;
                case "chewy":
                    this.calories *= 1.1;
                    break;
                case "homemade":
                    this.calories *= 1.0;
                    break;
            }
        }

    }
}
