using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
             this.FuelConsumption = fuelConsumption;
        }

        public double TankCapacity { get; private set; }

        public double FuelQuantity
        {
            get => this.fuelQuantity;

            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0) 
            {
                throw new ArgumentException("Fuel must be a positive number");
            } 

            double totalAmount = this.FuelQuantity + amount;

            if (totalAmount > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }

            this.FuelQuantity += amount;
        }

        public string Drive(double distance)
        {
            string vehicleName = this.GetType().Name;
            double fuelNeeded = this.FuelConsumption * distance;

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;

                return $"{vehicleName} travelled {distance} km";
            }
            else
            {
                return $"{vehicleName} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
