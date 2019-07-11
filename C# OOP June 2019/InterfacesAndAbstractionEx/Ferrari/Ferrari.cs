using Ferrari.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string model = "488-Spider";

        public Ferrari(string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string Model { get; }

        public string Driver { get ; private set ; }

        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.Driver}";
        }
    }
}
