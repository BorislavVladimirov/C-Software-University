using System;
using System.Collections.Generic;
using PizzaCalories.DifferentExceptions;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private int countOfToppings;
        private double calories;

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public double Calories
        {
            get { return this.calories; }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 1 || value.Length > 15 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPizzaName);
                }

                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
            private set
            {
                this.toppings = value;
            }
        }
        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }
        public int CountOfToppings
        {
            get
            {
                return this.toppings.Count;
            }
            private set
            {
                this.countOfToppings = this.toppings.Count;
            }
        }

        private void TotalCalories()
        {
            this.dough.TotalCalories();

            foreach (var topping in this.Toppings)
            {
                topping.TotalCalories();
            }

            this.calories = this.dough.Calories + this.toppings.Sum(x => x.Calories);
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            if (this.CountOfToppings < 0 || this.CountOfToppings > 10)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCountOfToppings);
            }

            this.TotalCalories();

            return $"{this.name} - {this.calories:f2} Calories.";
        }
    }
}
