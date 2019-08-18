using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double InitialUnitsOfOxygen = 70;
        private const double OxygenDecrease = 5;

        public Biologist(string name)
            : base(name, InitialUnitsOfOxygen)
        {
        }

        public override void Breath()
        {
            if (this.Oxygen - OxygenDecrease >= 0)
            {
                base.Oxygen -= OxygenDecrease;
            }
        }
    }
}
