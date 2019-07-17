using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalFuelConsumption = 1.6;
        private const double wastedFuel = 0.05;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + additionalFuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);

            this.FuelQuantity -= amount * wastedFuel;

        }
    }
}
