using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    class Bus : Vehicle
    {
        private const double additionalFuelConsumptionWithAC = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + additionalFuelConsumptionWithAC, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= additionalFuelConsumptionWithAC;
            return base.Drive(distance);
        }
    }
}
