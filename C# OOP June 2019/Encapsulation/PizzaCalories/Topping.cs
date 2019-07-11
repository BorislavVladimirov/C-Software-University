using System;
using PizzaCalories.DifferentExceptions;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;
        private double calories;


        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (value.ToLower() != "meat"
                    && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidToppingType, value));
                }

                this.type = value;
            }
        }
        public double Calories
        {
            get
            {
                return this.calories;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidToppingWeight, this.type));
                }

                this.weight = value;
            }
        }

        public void TotalCalories()
        {
            switch (this.type.ToLower())
            {
                case "meat":
                    this.calories = this.weight * 2 * 1.2;
                    break;
                case "veggies":
                    this.calories = this.weight * 2 * 0.8;
                    break;
                case "cheese":
                    this.calories = this.weight * 2 * 1.1;
                    break;
                case "sauce":
                    this.calories = this.weight * 2 * 0.9;
                    break;
            }
        }
    }
}
