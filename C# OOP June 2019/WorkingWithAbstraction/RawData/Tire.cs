using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(int age, double tirePressure)
        {
            this.Age = age;
            this.TirePressure = tirePressure;
        }

        public int Age { get; set; }

        public double TirePressure { get; set; }
    }
}
