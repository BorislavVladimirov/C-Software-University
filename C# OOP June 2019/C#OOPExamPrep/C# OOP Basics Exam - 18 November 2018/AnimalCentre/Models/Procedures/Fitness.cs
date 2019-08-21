using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Fitness : Procedure
    {
        private readonly int HappinessPointsToReduce = 3;
        private readonly int EnergyPointsToAdd = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;
            animal.Happiness -= HappinessPointsToReduce;
            animal.Energy += EnergyPointsToAdd;

            this.ProcedureHistory.Add(animal);
        }
    }
}
