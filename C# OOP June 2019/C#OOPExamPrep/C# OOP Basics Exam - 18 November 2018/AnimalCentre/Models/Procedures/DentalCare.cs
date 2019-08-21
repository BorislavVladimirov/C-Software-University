using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class DentalCare : Procedure
    {
        private readonly int HappinessPointsToAdd = 12;
        private readonly int EnergyPointsToIncrease = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Happiness += HappinessPointsToAdd;
            animal.Energy += EnergyPointsToIncrease;
            animal.ProcedureTime -= procedureTime;

            this.ProcedureHistory.Add(animal);
        }
    }
}
