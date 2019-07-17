using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    class Tiger : Feline
    {
        private const double GainValue = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, GainValue);
        }

        public override string ProduceSount()
        {
            return "ROAR!!!";
        }
    }
}
