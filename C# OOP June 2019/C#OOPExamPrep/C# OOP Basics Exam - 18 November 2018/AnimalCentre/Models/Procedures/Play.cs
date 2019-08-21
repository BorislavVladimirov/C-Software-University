using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Play : Procedure
    {
        private readonly int HappinessPointsToAdd = 12;
        private readonly int EnergyPointsToRemove = 6;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;
            animal.Happiness += HappinessPointsToAdd;
            animal.Energy -= EnergyPointsToRemove;

            this.ProcedureHistory.Add(animal);
        }
    }
}
