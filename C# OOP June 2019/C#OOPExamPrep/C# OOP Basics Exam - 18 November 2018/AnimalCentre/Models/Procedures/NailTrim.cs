using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class NailTrim : Procedure
    {
        private readonly int HappinessPointsToReduce = 7;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Happiness -= HappinessPointsToReduce;
            animal.ProcedureTime -= procedureTime;

            this.ProcedureHistory.Add(animal);
        }
    }
}
