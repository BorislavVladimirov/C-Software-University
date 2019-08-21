using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Chip : Procedure
    {
        private readonly int HappinessRedusing = 5;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Happiness -= HappinessRedusing;
            animal.ProcedureTime -= procedureTime;

            animal.IsChipped = true;

            this.ProcedureHistory.Add(animal);
        }
    }
}
