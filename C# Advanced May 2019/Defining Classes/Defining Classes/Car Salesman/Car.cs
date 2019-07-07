using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
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
        public Engine Engine
        {
            get
            {
                return this.engine;
            }

            set
            {
                this.engine = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                this.weight = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.model}:");
            sb.AppendLine($"  {this.engine}");
            sb.AppendLine($"  Weight: {((this.weight == -1) ? "n/a" : this.weight.ToString())}");
            sb.AppendLine($"  Color: {this.color}");

            return sb.ToString().TrimEnd();
        }
    }
}
