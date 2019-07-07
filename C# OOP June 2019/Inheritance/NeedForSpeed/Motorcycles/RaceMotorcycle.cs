using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.FuelConsumption = 8;
        }

        public override double FuelConsumption { get => base.FuelConsumption; set => base.FuelConsumption = 8; }
    }
}
