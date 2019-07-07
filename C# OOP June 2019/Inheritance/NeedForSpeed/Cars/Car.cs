using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Cars
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.FuelConsumption = 3;
        }
    }
}
