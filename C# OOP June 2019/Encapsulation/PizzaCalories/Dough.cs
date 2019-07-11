using System;
using PizzaCalories.DifferentExceptions;

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

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidWeight);
                }

                this.weight = value;
            }
        }

        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDough);
                }

                this.flourType = value;
            }

        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDough);
                }

                this.bakingTechnique = value;
            }
        }

        public double Calories
        {
            get
            {
                return this.calories;
            }
        }

        public void TotalCalories()
        {
            if (this.flourType.ToLower() == "white")
            {
                this.calories = 2 * this.weight * 1.5;
            }
            else
            {
                this.calories = 2 * this.weight * 1.0;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    this.calories *= 0.9;
                    break;
                case "chewy":
                    this.calories *= 1.1;
                    break;
                case "  ":
                    this.calories *= 1.0;
                    break;
            }
        }

    }
}
