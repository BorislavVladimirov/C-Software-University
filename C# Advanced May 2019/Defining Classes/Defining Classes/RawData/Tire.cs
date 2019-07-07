using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(int tireAge, double tirePressure)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }

        public int TireAge { get; }

        public double TirePressure { get; }
    }
}
