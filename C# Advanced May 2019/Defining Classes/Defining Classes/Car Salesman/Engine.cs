using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }
        public int Power
        {
            get
            {
                return this.power;
            }

            set
            {
                this.power = value;
            }
        }
        public int Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                this.displacement = value;
            }
        }
        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }

            set
            {
                this.efficiency = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.model}:");
            sb.AppendLine($"    Power: {this.power}");
            sb.AppendLine($"    Displacement: {((this.displacement == -1) ? "n/a" : this.displacement.ToString())}");
            sb.AppendLine($"    Efficiency: {this.efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
